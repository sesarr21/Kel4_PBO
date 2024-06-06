using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Kel4_PBO.Service
{
    public class PesananService
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=kinkapp;Username=postgres;Password=444Ses@r;";

        public DataTable GetTransactionData()
        {
            DataTable transactionData = new DataTable();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                    SELECT 
                        tanggal AS tanggal_transaksi, 
                        id_karyawan AS id_transaksi, 
                        total_transaksi 
                    FROM 
                        transaksi 
                    WHERE 
                        total_transaksi > 0";  // Tambahkan kondisi ini

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        adapter.Fill(transactionData);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error retrieving transaction data: {ex.Message}");
            }

            return transactionData;
        }
    }
}