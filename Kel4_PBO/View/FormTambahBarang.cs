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
    public partial class FormTambahBarang : Form
    {
        private readonly IChildFormHandler _childFormHandler;
        private readonly TambahBarangService _tambahBarangService;

        public FormTambahBarang(IChildFormHandler childFormHandler)
        {
            InitializeComponent();
            _childFormHandler = childFormHandler;
            _tambahBarangService = new TambahBarangService("Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp;Include Error Detail=true");
        }

        private void buttonkembali_Click(object sender, EventArgs e)
        {
            _childFormHandler.OpenChildForm(new FormDataBarang(_childFormHandler));
            this.Close();
        }

        private void buttonsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string idBarang = textBoxidbarang.Text;
                string kategori = textBoxkategori.Text;
                string namaBarang = textBoxnamabarang.Text;
                int hargaJual = int.Parse(textBoxhargajual.Text);
                int jumlahStok = int.Parse(textBoxstok.Text);
                int hargaBeli = int.Parse(textBoxhargabeli.Text);
                DateTime tanggalMasuk = dateTimetglmasuk.Value;

                _tambahBarangService.TambahBarang(idBarang, kategori, namaBarang, hargaJual, jumlahStok, hargaBeli, tanggalMasuk);

                MessageBox.Show("Data berhasil disimpan!");

                // Reset input fields
                textBoxidbarang.Clear();
                textBoxkategori.Clear();
                textBoxnamabarang.Clear();
                textBoxhargajual.Clear();
                textBoxstok.Clear();
                textBoxhargabeli.Clear();
                dateTimetglmasuk.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}