using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class LoginService
    {
        private string _connectionString;

        public LoginService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public (bool, string, string, string) AuthenticateUser(string username, string password)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT role, id_akun, id_karyawan FROM akun WHERE username = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader.GetString(reader.GetOrdinal("role"));
                        string userId = reader.GetString(reader.GetOrdinal("id_akun"));
                        string karyawanId = reader.GetString(reader.GetOrdinal("id_karyawan"));
                        return (true, role, userId, karyawanId);
                    }
                    else
                    {
                        return (false, null, null, null);
                    }
                }
            }
        }
    }
}