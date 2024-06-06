using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Service
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime TanggalPendaftaran { get; set; }

    }

    public class DataKaryawanService
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp";
        public List<Karyawan> karyawanList = new List<Karyawan>();

        public bool Read()
        {
            bool isSuccess = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT nama, alamat, username, password, tanggal_pendaftaran FROM karyawan JOIN akun ON karyawan.id_karyawan = akun.id_karyawan";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            karyawanList.Clear();
                            while (reader.Read())
                            {
                                Karyawan newKaryawan = new Karyawan();
                                newKaryawan.Nama = reader["nama"] != DBNull.Value ? (string)reader["nama"] : string.Empty;
                                newKaryawan.Alamat = reader["alamat"] != DBNull.Value ? (string)reader["alamat"] : string.Empty;
                                newKaryawan.Username = reader["username"] != DBNull.Value ? (string)reader["username"] : string.Empty;
                                newKaryawan.Password = reader["password"] != DBNull.Value ? (string)reader["password"] : string.Empty;
                                newKaryawan.TanggalPendaftaran = reader["tanggal_pendaftaran"] != DBNull.Value ? (DateTime)reader["tanggal_pendaftaran"] : DateTime.MinValue;
                                karyawanList.Add(newKaryawan);
                            }
                            isSuccess = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isSuccess;
        }
       

        public bool Insert(string nama, string alamat, string username, string password,string idAkun, String idKaryawan, DateTime tanggalPendaftaran)
        {
            bool isSuccess = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                           

                            // Insert into karyawan table
                            string query = @"
                    INSERT INTO karyawan (id_karyawan, nama, alamat, tanggal_pendaftaran)
                    VALUES (@id_karyawan, @nama, @alamat, @tanggalPendaftaran)";

                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@id_karyawan", idKaryawan);
                                command.Parameters.AddWithValue("@nama", nama);
                                command.Parameters.AddWithValue("@alamat", alamat);
                                command.Parameters.AddWithValue("@tanggalPendaftaran", tanggalPendaftaran);

                                command.ExecuteNonQuery();
                            }

                            // Insert into akun table
                            string akunQuery = @"
                    INSERT INTO akun (username, password, id_karyawan)
                    VALUES (@username, @password, @id_karyawan)";

                            using (NpgsqlCommand akunCommand = new NpgsqlCommand(akunQuery, connection, transaction))
                            {
                                akunCommand.Parameters.AddWithValue("@id_akun", idAkun);
                                akunCommand.Parameters.AddWithValue("@username", username);
                                akunCommand.Parameters.AddWithValue("@password", password);
                                akunCommand.Parameters.AddWithValue("@id_karyawan", idKaryawan);

                                int rowsAffected = akunCommand.ExecuteNonQuery();
                                isSuccess = rowsAffected > 0;
                            }

                            // Commit the transaction
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine("Error: " + ex.Message);
                            isSuccess = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isSuccess;
        }
        


        public bool Delete(Karyawan karyawan)
        {
            bool isSuccess = false;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM karyawan WHERE nama = @nama";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nama", karyawan.Nama);

                        int rowsAffected = command.ExecuteNonQuery();
                        isSuccess = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isSuccess;
        }
        
    }
}