﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class TransaksiService
    {
        private string connectionString = "Host=localhost;username=postgres;password=444Ses@r;database=kinkapp";

        public int CreateTransaksi(string idKaryawan)
        {
            int idTransaksi = 0;
            string query = @"
            INSERT INTO transaksi (id_karyawan, total_transaksi, tanggal)
            VALUES (@IdKaryawan, 0, current_timestamp)
            RETURNING id_transaksi;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (string.IsNullOrEmpty(idKaryawan))
                    {
                        command.Parameters.Add(new NpgsqlParameter("@IdKaryawan", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = DBNull.Value });
                    }
                    else
                    {
                        command.Parameters.Add(new NpgsqlParameter("@IdKaryawan", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = idKaryawan });
                    }

                    idTransaksi = (int)command.ExecuteScalar();
                }
            }

            return idTransaksi;
        }

        public void AddDetailTransaksi(int idTransaksi, string idBarang, int jumlah, int hargaJual)
        {
            try
            {
                string queryDetail = @"
                INSERT INTO detail_transaksi (id_transaksi, id_barang, jumlah, total_harga)
                VALUES (@IdTransaksi, @IdBarang, @Jumlah, @TotalHarga);";

                string queryUpdateTotal = @"
                UPDATE transaksi
                SET total_transaksi = (SELECT SUM(total_harga) FROM detail_transaksi WHERE id_transaksi = @IdTransaksi)
                WHERE id_transaksi = @IdTransaksi;";

                string queryGetStok = @"
                SELECT id_stok, jumlah_stok 
                FROM stok 
                WHERE id_barang = @IdBarang AND jumlah_stok > 0
                ORDER BY tanggal_masuk
                FOR UPDATE;";

                string queryUpdateStock = @"
                UPDATE stok
                SET jumlah_stok = jumlah_stok - @Jumlah
                WHERE id_stok = @IdStok;";

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert detail transaksi
                            using (var command = new NpgsqlCommand(queryDetail, connection, transaction))
                            {
                                command.Parameters.Add(new NpgsqlParameter("@IdTransaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi });
                                command.Parameters.Add(new NpgsqlParameter("@IdBarang", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = idBarang ?? (object)DBNull.Value });
                                command.Parameters.Add(new NpgsqlParameter("@Jumlah", NpgsqlTypes.NpgsqlDbType.Integer) { Value = jumlah });
                                command.Parameters.Add(new NpgsqlParameter("@TotalHarga", NpgsqlTypes.NpgsqlDbType.Integer) { Value = jumlah * hargaJual });
                                command.ExecuteNonQuery();
                            }

                            // Update total transaksi
                            using (var command = new NpgsqlCommand(queryUpdateTotal, connection, transaction))
                            {
                                command.Parameters.Add(new NpgsqlParameter("@IdTransaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi });
                                command.ExecuteNonQuery();
                            }

                            
                            using (var command = new NpgsqlCommand(queryGetStok, connection, transaction))
                            {
                                command.Parameters.Add(new NpgsqlParameter("@IdBarang", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = idBarang });

                                using (var reader = command.ExecuteReader())
                                {
                                    while (jumlah > 0 && reader.Read())
                                    {
                                        int idStok = reader.GetInt32(0);
                                        int jumlahStok = reader.GetInt32(1);

                                        int pengurangan = Math.Min(jumlah, jumlahStok);
                                        jumlah -= pengurangan;

                                        reader.Close(); 

                                        using (var updateCommand = new NpgsqlCommand(queryUpdateStock, connection, transaction))
                                        {
                                            updateCommand.Parameters.Add(new NpgsqlParameter("@IdStok", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idStok });
                                            updateCommand.Parameters.Add(new NpgsqlParameter("@Jumlah", NpgsqlTypes.NpgsqlDbType.Integer) { Value = pengurangan });
                                            updateCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Kesalahan saat menambahkan detail transaksi: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Kesalahan saat menambahkan detail transaksi: " + ex.Message);
            }
        }

        public DataTable GetDetailTransaksiById(int idTransaksi)
        {
            string query = @"
            SELECT barang.nama_barang, barang.harga_jual, detail_transaksi.jumlah, detail_transaksi.total_harga
            FROM detail_transaksi
            JOIN barang ON detail_transaksi.id_barang = barang.id_barang
            WHERE detail_transaksi.id_transaksi = @IdTransaksi;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("@IdTransaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi });

                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public int GetTotalTransaksi(int idTransaksi)
        {
            string query = "SELECT total_transaksi FROM transaksi WHERE id_transaksi = @IdTransaksi";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("@IdTransaksi", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idTransaksi });
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public (string namaBarang, int hargaJual, int jumlahStok) GetBarangAndStokById(string idBarang)
        {
            string query = @"
            SELECT barang.nama_barang, barang.harga_jual, COALESCE(SUM(stok.jumlah_stok), 0) AS jumlah_stok
            FROM barang
            LEFT JOIN stok ON barang.id_barang = stok.id_barang
            WHERE barang.id_barang = @IdBarang
            GROUP BY barang.nama_barang, barang.harga_jual;";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.Add(new NpgsqlParameter("@IdBarang", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = idBarang });

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2));
                        }
                        else
                        {
                            return (null, 0, 0);
                        }
                    }
                }
            }
        }
    }
}