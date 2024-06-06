using Kel4_PBO.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Kel4_PBO.View
{
    public partial class FormDataKaryawan : Form
    {
        private DataKaryawanService dataKaryawanService;
        private DateTimePicker dateTimetglpendaftaran; // Ganti tipe data menjadi DateTimePicker

        public FormDataKaryawan()
        {
            InitializeComponent();
            dataKaryawanService = new DataKaryawanService();
            InitializeDataGridView();
            InitializeDateTimePicker();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridViewNamaKaryawan.ColumnCount = 5;
            dataGridViewNamaKaryawan.Columns[0].Name = "Nama Karyawan";
            dataGridViewNamaKaryawan.Columns[1].Name = "Alamat";
            dataGridViewNamaKaryawan.Columns[2].Name = "Username";
            dataGridViewNamaKaryawan.Columns[3].Name = "Password";
            dataGridViewNamaKaryawan.Columns[4].Name = "Tanggal Pendaftaran";
            dataGridViewNamaKaryawan.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);

        }

        private void InitializeDateTimePicker()
        {
            dateTimetglpendaftaran = new DateTimePicker();
            dateTimetglpendaftaran.Format = DateTimePickerFormat.Short;
            dateTimetglpendaftaran.Location = new Point(120, 150); // Atur lokasi sesuai kebutuhan
            Controls.Add(dateTimetglpendaftaran);
        }

        private void LoadData()
        {
            if (dataKaryawanService.Read())
            {
                dataGridViewNamaKaryawan.Rows.Clear();
                foreach (var karyawan in dataKaryawanService.karyawanList)
                {
                    dataGridViewNamaKaryawan.Rows.Add(karyawan.Nama, karyawan.Alamat, karyawan.Username, karyawan.Password, karyawan.TanggalPendaftaran);
                }
            }
            else
            {
                MessageBox.Show("Failed to load data from database.");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            e.CellStyle.ForeColor = Color.Black;
        }




        private void buttonkembali_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup form saat tombol diklik
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewNamaKaryawan.SelectedRows.Count > 0)
            {
                // Loop melalui setiap baris yang dipilih dan hapus
                foreach (DataGridViewRow row in dataGridViewNamaKaryawan.SelectedRows)
                {
                    // Hapus baris dari DataGridView
                    dataGridViewNamaKaryawan.Rows.Remove(row);

                }

                MessageBox.Show("Data berhasil dihapus.");
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang ingin dihapus.");
            }
        }


        private void dataGridViewNamaKaryawan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNamaKaryawan.Rows[e.RowIndex];

                txtnama.Text = row.Cells["Nama Karyawan"].Value.ToString();
                txtalamat.Text = row.Cells["Alamat"].Value.ToString();
                txtusername.Text = row.Cells["Username"].Value.ToString();
                txtpassword.Text = row.Cells["Password"].Value.ToString();
                dateTimetglpendaftaran.Value = Convert.ToDateTime(row.Cells["Tanggal Pendaftaran"].Value);
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string koneksi = "Server=localhost;Username=postgres;Password=revindavivi;Port=5432;Database=kinkapp;Pooling=true";
            NpgsqlConnection conn = new NpgsqlConnection(koneksi);
            conn.Open();

            string idAkun = textidAkun.Text;
            string idKaryawan = textidKaryawan.Text;
            string nama = txtnama.Text;
            string alamat = txtalamat.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string role = "karyawan";
            var tanggalPendaftaran = dateTimePendaftaran.Value;
            string query = $"INSERT INTO karyawan(id_karyawan,nama,alamat,tanggal_pendaftaran) VALUES('{idKaryawan}', '{nama}', '{alamat}', '{tanggalPendaftaran}');INSERT INTO akun(id_akun,id_karyawan,username,\"password\",\"role\") VALUES('{idAkun}', '{idKaryawan}', '{username}', '{password}', '{role}');";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            textidAkun.Clear();
            textidKaryawan.Clear();
            txtnama.Clear();
            txtalamat.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            dateTimetglpendaftaran.Value = DateTime.Now;
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
