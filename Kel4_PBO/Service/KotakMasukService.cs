using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class KotakMasukService
    {
        public string ConnectionString { get; } = "Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp";

        public List<BarangStok> GetBarangStokKurangDari(int batasStok)
        {
            var barangStokList = new List<BarangStok>();

            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                SELECT barang.id_barang, SUM(stok.jumlah_stok) AS total_stok 
                FROM stok
                INNER JOIN barang ON stok.id_barang = barang.id_barang
                WHERE stok.is_read = FALSE
                GROUP BY barang.id_barang
                HAVING SUM(stok.jumlah_stok) < @batasStok";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("batasStok", batasStok);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            barangStokList.Add(new BarangStok
                            {
                                IdBarang = reader.GetString(0),
                                TotalStok = reader.GetInt32(1)
                            });
                        }
                    }
                }
            }

            return barangStokList;
        }

        public void MarkBarangAsRead(string idBarang)
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "UPDATE stok SET is_read = TRUE WHERE id_barang = @idBarang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idBarang", idBarang);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MarkAllBarangAsRead()
        {
            using (var conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                UPDATE stok
                SET is_read = TRUE
                WHERE id_barang IN (
                    SELECT id_barang
                    FROM stok
                    GROUP BY id_barang
                    HAVING SUM(jumlah_stok) < 15
                )";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


    public class BarangStok
    {
        public string IdBarang { get; set; }
        public int TotalStok { get; set; }
    }

}