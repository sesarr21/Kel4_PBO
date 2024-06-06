using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Kel4_PBO.Service
{
    public class TambahBarangService
    {
        private readonly string _connectionString;

        public TambahBarangService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void TambahBarang(string idBarang, string kategori, string namaBarang, int hargaJual, int jumlahStok, int hargaBeli, DateTime tanggalMasuk)
        {
            string idJenis = GetIdJenis(kategori);

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Check if the barang already exists
                        var command = new NpgsqlCommand("SELECT COUNT(*) FROM barang WHERE id_barang = @id_barang OR nama_barang = @nama_barang", conn);
                        command.Parameters.AddWithValue("id_barang", idBarang);
                        command.Parameters.AddWithValue("nama_barang", namaBarang);
                        long count = (long)command.ExecuteScalar(); // Changed to long

                        if (count > 0)
                        {
                            // Update harga_jual if different
                            command = new NpgsqlCommand("UPDATE barang SET harga_jual = @harga_jual WHERE id_barang = @id_barang AND harga_jual != @harga_jual", conn);
                            command.Parameters.AddWithValue("harga_jual", hargaJual);
                            command.Parameters.AddWithValue("id_barang", idBarang);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            // Insert into barang
                            command = new NpgsqlCommand("INSERT INTO barang (id_barang, id_jenis, nama_barang, harga_jual) VALUES (@id_barang, @id_jenis, @nama_barang, @harga_jual)", conn);
                            command.Parameters.AddWithValue("id_barang", idBarang);
                            command.Parameters.AddWithValue("id_jenis", idJenis);
                            command.Parameters.AddWithValue("nama_barang", namaBarang);
                            command.Parameters.AddWithValue("harga_jual", hargaJual);
                            command.ExecuteNonQuery();
                        }

                        // Verify the barang exists before inserting into stok
                        command = new NpgsqlCommand("SELECT COUNT(*) FROM barang WHERE id_barang = @id_barang", conn);
                        command.Parameters.AddWithValue("id_barang", idBarang);
                        count = (long)command.ExecuteScalar();

                        if (count == 0)
                        {
                            throw new Exception("Failed to verify the existence of barang before inserting into stok.");
                        }

                        // Insert into stok
                        command = new NpgsqlCommand("INSERT INTO stok (id_barang, jumlah_stok, tanggal_masuk, harga_beli) VALUES (@id_barang, @jumlah_stok, @tanggal_masuk, @harga_beli)", conn);
                        command.Parameters.AddWithValue("id_barang", idBarang);
                        command.Parameters.AddWithValue("jumlah_stok", jumlahStok);
                        command.Parameters.AddWithValue("tanggal_masuk", tanggalMasuk);
                        command.Parameters.AddWithValue("harga_beli", hargaBeli);
                        command.ExecuteNonQuery();

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        // Display the full error message for debugging
                        throw new Exception("Error while adding or updating barang: " + ex.Message, ex);
                    }
                }
            }
        }

        private string GetIdJenis(string kategori)
        {
            switch (kategori.ToLower())
            {
                case "makanan":
                    return "MKN";
                case "minuman":
                    return "MNM";
                case "kebutuhan rumah tangga":
                    return "KRT";
                case "rokok":
                    return "RKK";
                default:
                    throw new Exception("Kategori tidak valid.");
            }
        }
    }
}