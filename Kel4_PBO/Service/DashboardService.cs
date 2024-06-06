using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class DashboardService
    {
        private readonly string _connectionString;

        public DashboardService()
        {
            _connectionString = "Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp";
        }

        public decimal GetTotalOmzetLast30Days()
        {
            string query = @"
            SELECT SUM(total_transaksi) 
            FROM transaksi 
            WHERE tanggal >= CURRENT_DATE - INTERVAL '30 days'";

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        public List<KeyValuePair<string, int>> GetTop5BarangTerlaku()
        {
            List<KeyValuePair<string, int>> topBarang = new List<KeyValuePair<string, int>>();
            string query = @"
            SELECT b.nama_barang, SUM(dt.jumlah) as total_terjual
            FROM detail_transaksi dt
            JOIN barang b ON dt.id_barang = b.id_barang
            GROUP BY b.nama_barang
            ORDER BY total_terjual DESC
            LIMIT 5";

            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string namaBarang = reader.GetString(0);
                            int totalTerjual = reader.GetInt32(1);
                            topBarang.Add(new KeyValuePair<string, int>(namaBarang, totalTerjual));
                        }
                    }
                }
            }
            return topBarang;
        }

        public List<KeyValuePair<DateTime, decimal>> GetTransaksiData(int days)
        {
            List<KeyValuePair<DateTime, decimal>> data = new List<KeyValuePair<DateTime, decimal>>();

            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();

                // Menggunakan interpolasi string untuk menyisipkan nilai interval
                string query = $@"
            SELECT tanggal, SUM(total_transaksi) as total_harian
            FROM transaksi
            WHERE tanggal >= (CURRENT_DATE - INTERVAL '{days} days')
            GROUP BY tanggal
            ORDER BY tanggal";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tanggal = reader.GetDateTime(0);
                            decimal totalHarian = reader.GetDecimal(1);
                            data.Add(new KeyValuePair<DateTime, decimal>(tanggal, totalHarian));
                        }
                    }
                }
            }

            return data;
        }

        public decimal GetOmzetMingguIni()
        {
            string query = @"
            SELECT COALESCE(SUM(total_transaksi), 0)
            FROM transaksi
            WHERE tanggal >= NOW()::date - EXTRACT(DOW FROM NOW())::integer
            AND tanggal < NOW()::date + 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToDecimal((long)cmd.ExecuteScalar());
                }
            }
        }

        public decimal GetOmzetMingguLalu()
        {
            string query = @"
            SELECT COALESCE(SUM(total_transaksi), 0)
            FROM transaksi
            WHERE tanggal >= NOW()::date - EXTRACT(DOW FROM NOW())::integer - 7
            AND tanggal < NOW()::date - EXTRACT(DOW FROM NOW())::integer";

            using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    return Convert.ToDecimal((long)cmd.ExecuteScalar());
                }
            }
        }
    }
}
