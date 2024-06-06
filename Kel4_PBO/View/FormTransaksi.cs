using Kel4_PBO.Service;
using System.Data;
using System.Windows.Forms;

namespace Kel4_PBO.View
{
    public partial class FormTransaksi : Form
    {
        private TransaksiService transaksiService;
        private int idTransaksi;
        private string idKaryawan;

        public FormTransaksi()
        {
            InitializeComponent();
            transaksiService = new TransaksiService();
            idKaryawan = Session.KaryawanId;
            idTransaksi = transaksiService.CreateTransaksi(idKaryawan);
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGriddetail.AutoGenerateColumns = false;
            dataGriddetail.Columns.Clear();

            dataGriddetail.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nama Barang",
                DataPropertyName = "nama_barang",
                Name = "nama_barang"
            });
            dataGriddetail.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Harga",
                DataPropertyName = "harga_jual",
                Name = "harga_jual"
            });
            dataGriddetail.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Jumlah",
                DataPropertyName = "jumlah",
                Name = "jumlah"
            });
            dataGriddetail.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Harga",
                DataPropertyName = "total_harga",
                Name = "total_harga"
            });
            dataGriddetail.ForeColor = Color.Black;
            dataGriddetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGriddetail.RowHeadersVisible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string idBarang = textBoxidbarang.Text;
                var (namaBarang, hargaJual, jumlahStok) = transaksiService.GetBarangAndStokById(idBarang);

                if (namaBarang != null)
                {
                    lblNama.Text = namaBarang;
                    lblHarga.Text = hargaJual.ToString();
                    lblJmlStok.Text = jumlahStok.ToString();
                }
                else
                {
                    MessageBox.Show("Barang dengan ID tersebut tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblNama.Text = "";
                    lblHarga.Text = "";
                    lblJmlStok.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string idBarang = textBoxidbarang.Text;
                if (string.IsNullOrEmpty(idBarang))
                {
                    MessageBox.Show("ID Barang tidak boleh kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!int.TryParse(tbJml.Text, out int jumlah) || jumlah <= 0)
                {
                    MessageBox.Show("Jumlah harus berupa angka positif.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var (namaBarang, hargaJual, jumlahStok) = transaksiService.GetBarangAndStokById(idBarang);
                if (namaBarang != null)
                {
                    transaksiService.AddDetailTransaksi(idTransaksi, idBarang, jumlah, hargaJual);

                    DataTable dt = transaksiService.GetDetailTransaksiById(idTransaksi);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        dataGriddetail.DataSource = dt;
                        int totalTransaksi = transaksiService.GetTotalTransaksi(idTransaksi);
                        lblTotal.Text = totalTransaksi.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada detail transaksi yang ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Barang dengan ID tersebut tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tbUangDiterima.Text, out int uangDiterima) && int.TryParse(lblTotal.Text, out int total))
                {
                    if (uangDiterima >= total)
                    {
                        int kembalian = uangDiterima - total;
                        lblKembalian.Text = kembalian.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Uang yang diterima harus lebih besar dari total transaksi.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan nilai numerik yang valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            textBoxidbarang.Text = "";
            tbJml.Text = "";
            lblNama.Text = "";
            lblHarga.Text = "";
            lblJmlStok.Text = "";
            lblTotal.Text = "0";
            lblKembalian.Text = "0";
            tbUangDiterima.Text = "";

            dataGriddetail.DataSource = null;

            idTransaksi = transaksiService.CreateTransaksi(idKaryawan);
        }
    }
}