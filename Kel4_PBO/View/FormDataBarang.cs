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

namespace Kel4_PBO.View
{
    public partial class FormDataBarang : Form
    {
        private readonly IChildFormHandler _childFormHandler;
        private readonly DataBarangService _dataBarangService;
        private int currentPage;
        private const int PageSize = 10;

        public FormDataBarang(IChildFormHandler childFormHandler)
        {
            InitializeComponent();
            _childFormHandler = childFormHandler;
            _dataBarangService = new DataBarangService();
            currentPage = 0;
            LoadDataBarang(currentPage);
        }

        private void LoadDataBarang(int page)
        {
            int offset = page * PageSize;
            DataTable barangData = _dataBarangService.GetBarangData(offset, PageSize);
            dataGridView1.DataSource = barangData;

            if (!columnsConfigured)
            {
                ConfigureDataGridViewColumns();
                columnsConfigured = true; // Pastikan konfigurasi hanya dijalankan sekali
            }
        }

        private void iconButtontambah_Click(object sender, EventArgs e)
        {
            _childFormHandler.OpenChildForm(new FormTambahBarang(_childFormHandler));
        }


        private void ConfigureDataGridViewColumns()
        {
            // Mengatur nama header kolom
            dataGridView1.Columns["nama_barang"].HeaderText = "Nama Barang";
            dataGridView1.Columns["stok"].HeaderText = "Stok";
            dataGridView1.Columns["kategori"].HeaderText = "Kategori";
            dataGridView1.Columns["harga_beli"].HeaderText = "Harga Beli";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }

        private bool columnsConfigured = false;

        private void btnnext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadDataBarang(currentPage);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadDataBarang(currentPage);
            }
        }

        private void iconButtonsearch_Click(object sender, EventArgs e)
        {
            string idBarang = textBoxsearch.Text.Trim();
            if (string.IsNullOrEmpty(idBarang))
            {
                MessageBox.Show("Silakan masukkan ID Barang untuk pencarian.");
                return;
            }

            DataTable result = _dataBarangService.GetBarangData(0, PageSize, idBarang);
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data yang ditemukan untuk ID Barang tersebut.");
                return;
            }

            dataGridView1.DataSource = result;
        }
    }
}