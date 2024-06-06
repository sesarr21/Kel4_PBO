using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class DataBarangService
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp"; // Ganti dengan connection string Anda

        public DataTable GetBarangData(int offset, int limit, string id_barang = null)
        {
            DataTable dataTable = new DataTable();

            string stokCondition = "s.jumlah_stok > 0";
            string filter = "";
            if (!string.IsNullOrEmpty(id_barang))
            {
                filter = "AND b.id_barang = @id_barang ";
                stokCondition = "(s.jumlah_stok >= 0 OR s.jumlah_stok IS NULL)";  // Biarkan tampil meskipun stok 0 jika ada pencarian spesifik
            }

            string query = $@"
        SELECT 
            b.nama_barang,
            COALESCE(SUM(s.jumlah_stok), 0) AS stok,
            CASE b.id_jenis
                WHEN 'MKN' THEN 'Makanan'
                WHEN 'MNM' THEN 'Minuman'
                WHEN 'KRT' THEN 'Kebutuhan Rumah Tangga'
                WHEN 'RKK' THEN 'Rokok'
                ELSE 'Lainnya'
            END AS kategori,
            MAX(s.harga_beli) AS harga_beli
        FROM 
            barang b
        LEFT JOIN 
            stok s ON b.id_barang = s.id_barang
        LEFT JOIN
            jenis_barang j ON b.id_jenis = j.id_jenis
        WHERE 
            {stokCondition}
        {filter}
        GROUP BY 
            b.nama_barang, b.id_jenis
        ORDER BY 
            b.nama_barang
        OFFSET @offset LIMIT @limit";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@offset", offset);
                    command.Parameters.AddWithValue("@limit", limit);
                    if (!string.IsNullOrEmpty(id_barang))
                    {
                        command.Parameters.AddWithValue("@id_barang", id_barang);
                    }

                    try
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }

            return dataTable;
        }

    }
}