using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Kel4_PBO.Service.PesananService;
using System.Data.Common;
using Kel4_PBO.Service;

namespace Kel4_PBO.View
{
    public partial class FormPesanan : Form
    {
        private readonly PesananService _pesananService;
        public FormPesanan()
        {
            InitializeComponent();
            _pesananService = new PesananService();
            LoadTransactionData();
            SetupdataGridView();
        }

        private void LoadTransactionData()
        {
            try
            {
                // Ambil data transaksi dari PesananService
                var transactionData = _pesananService.GetTransactionData();

                if (transactionData != null && transactionData.Rows.Count > 0)
                {
                    dataGridView1.DataSource = transactionData;

                    // Konfigurasikan setiap kolom untuk mengisi ruang yang tersedia
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error details: {ex}");
            }
        }


        private void SetupdataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tanggal Transaksi",
                DataPropertyName = "tanggal_transaksi",
                Name = "tanggal_transaksi"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID Transaksi",
                DataPropertyName = "id_transaksi",
                Name = "id_transaksi"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Transaksi",
                DataPropertyName = "total_transaksi",
                Name = "total_transaksi"
            });
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}

