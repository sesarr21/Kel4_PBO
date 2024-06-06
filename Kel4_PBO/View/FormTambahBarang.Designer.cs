namespace Kel4_PBO.View
{
    partial class FormTambahBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonkembali = new Button();
            panel1 = new Panel();
            textBoxhargabeli = new TextBox();
            labelhargabeli = new Label();
            textBoxidbarang = new TextBox();
            labelidbarang = new Label();
            textBoxkategori = new TextBox();
            textBoxstok = new TextBox();
            labelkategori = new Label();
            labelstok = new Label();
            dateTimetglmasuk = new DateTimePicker();
            textBoxhargajual = new TextBox();
            textBoxnamabarang = new TextBox();
            labeltglmasuk = new Label();
            labelhargajual = new Label();
            labelnamabarang = new Label();
            labeltambahbarang = new Label();
            buttonsimpan = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonkembali
            // 
            buttonkembali.FlatAppearance.BorderSize = 3;
            buttonkembali.FlatStyle = FlatStyle.Flat;
            buttonkembali.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonkembali.ForeColor = Color.FromArgb(255, 102, 36);
            buttonkembali.Location = new Point(25, 373);
            buttonkembali.Name = "buttonkembali";
            buttonkembali.Size = new Size(131, 35);
            buttonkembali.TabIndex = 0;
            buttonkembali.Text = "Kembali";
            buttonkembali.UseVisualStyleBackColor = true;
            buttonkembali.Click += buttonkembali_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxhargabeli);
            panel1.Controls.Add(labelhargabeli);
            panel1.Controls.Add(textBoxidbarang);
            panel1.Controls.Add(labelidbarang);
            panel1.Controls.Add(textBoxkategori);
            panel1.Controls.Add(textBoxstok);
            panel1.Controls.Add(labelkategori);
            panel1.Controls.Add(labelstok);
            panel1.Controls.Add(dateTimetglmasuk);
            panel1.Controls.Add(textBoxhargajual);
            panel1.Controls.Add(textBoxnamabarang);
            panel1.Controls.Add(labeltglmasuk);
            panel1.Controls.Add(labelhargajual);
            panel1.Controls.Add(labelnamabarang);
            panel1.Controls.Add(labeltambahbarang);
            panel1.Controls.Add(buttonsimpan);
            panel1.Controls.Add(buttonkembali);
            panel1.Location = new Point(39, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 457);
            panel1.TabIndex = 1;
            // 
            // textBoxhargabeli
            // 
            textBoxhargabeli.Font = new Font("Segoe UI", 12F);
            textBoxhargabeli.Location = new Point(200, 106);
            textBoxhargabeli.Name = "textBoxhargabeli";
            textBoxhargabeli.Size = new Size(131, 29);
            textBoxhargabeli.TabIndex = 17;
            // 
            // labelhargabeli
            // 
            labelhargabeli.AutoSize = true;
            labelhargabeli.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelhargabeli.Location = new Point(200, 68);
            labelhargabeli.Name = "labelhargabeli";
            labelhargabeli.Size = new Size(81, 21);
            labelhargabeli.TabIndex = 16;
            labelhargabeli.Text = "Harga Beli";
            // 
            // textBoxidbarang
            // 
            textBoxidbarang.Font = new Font("Segoe UI", 12F);
            textBoxidbarang.Location = new Point(25, 200);
            textBoxidbarang.Name = "textBoxidbarang";
            textBoxidbarang.Size = new Size(131, 29);
            textBoxidbarang.TabIndex = 15;
            // 
            // labelidbarang
            // 
            labelidbarang.AutoSize = true;
            labelidbarang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelidbarang.Location = new Point(25, 162);
            labelidbarang.Name = "labelidbarang";
            labelidbarang.Size = new Size(78, 21);
            labelidbarang.TabIndex = 14;
            labelidbarang.Text = "ID Barang";
            // 
            // textBoxkategori
            // 
            textBoxkategori.Font = new Font("Segoe UI", 12F);
            textBoxkategori.Location = new Point(375, 200);
            textBoxkategori.Name = "textBoxkategori";
            textBoxkategori.Size = new Size(131, 29);
            textBoxkategori.TabIndex = 13;
            // 
            // textBoxstok
            // 
            textBoxstok.Font = new Font("Segoe UI", 12F);
            textBoxstok.Location = new Point(200, 200);
            textBoxstok.Name = "textBoxstok";
            textBoxstok.Size = new Size(131, 29);
            textBoxstok.TabIndex = 12;
            // 
            // labelkategori
            // 
            labelkategori.AutoSize = true;
            labelkategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelkategori.Location = new Point(375, 162);
            labelkategori.Name = "labelkategori";
            labelkategori.Size = new Size(68, 21);
            labelkategori.TabIndex = 11;
            labelkategori.Text = "Kategori";
            // 
            // labelstok
            // 
            labelstok.AutoSize = true;
            labelstok.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelstok.Location = new Point(200, 162);
            labelstok.Name = "labelstok";
            labelstok.Size = new Size(40, 21);
            labelstok.TabIndex = 10;
            labelstok.Text = "Stok";
            // 
            // dateTimetglmasuk
            // 
            dateTimetglmasuk.Location = new Point(25, 296);
            dateTimetglmasuk.Name = "dateTimetglmasuk";
            dateTimetglmasuk.Size = new Size(200, 23);
            dateTimetglmasuk.TabIndex = 9;
            // 
            // textBoxhargajual
            // 
            textBoxhargajual.Font = new Font("Segoe UI", 12F);
            textBoxhargajual.Location = new Point(375, 106);
            textBoxhargajual.Name = "textBoxhargajual";
            textBoxhargajual.Size = new Size(131, 29);
            textBoxhargajual.TabIndex = 7;
            // 
            // textBoxnamabarang
            // 
            textBoxnamabarang.Font = new Font("Segoe UI", 12F);
            textBoxnamabarang.Location = new Point(25, 106);
            textBoxnamabarang.Name = "textBoxnamabarang";
            textBoxnamabarang.Size = new Size(131, 29);
            textBoxnamabarang.TabIndex = 6;
            // 
            // labeltglmasuk
            // 
            labeltglmasuk.AutoSize = true;
            labeltglmasuk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltglmasuk.Location = new Point(25, 256);
            labeltglmasuk.Name = "labeltglmasuk";
            labeltglmasuk.Size = new Size(113, 21);
            labeltglmasuk.TabIndex = 5;
            labeltglmasuk.Text = "Tanggal Masuk";
            // 
            // labelhargajual
            // 
            labelhargajual.AutoSize = true;
            labelhargajual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelhargajual.Location = new Point(375, 68);
            labelhargajual.Name = "labelhargajual";
            labelhargajual.Size = new Size(83, 21);
            labelhargajual.TabIndex = 4;
            labelhargajual.Text = "Harga Jual";
            // 
            // labelnamabarang
            // 
            labelnamabarang.AutoSize = true;
            labelnamabarang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnamabarang.Location = new Point(25, 68);
            labelnamabarang.Name = "labelnamabarang";
            labelnamabarang.Size = new Size(105, 21);
            labelnamabarang.TabIndex = 3;
            labelnamabarang.Text = "Nama Barang";
            // 
            // labeltambahbarang
            // 
            labeltambahbarang.AutoSize = true;
            labeltambahbarang.BackColor = Color.FromArgb(35, 35, 35);
            labeltambahbarang.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltambahbarang.ForeColor = Color.White;
            labeltambahbarang.Location = new Point(25, 19);
            labeltambahbarang.Name = "labeltambahbarang";
            labeltambahbarang.Size = new Size(165, 30);
            labeltambahbarang.TabIndex = 2;
            labeltambahbarang.Text = "Tambah Barang";
            // 
            // buttonsimpan
            // 
            buttonsimpan.BackColor = Color.FromArgb(255, 102, 36);
            buttonsimpan.FlatAppearance.BorderSize = 0;
            buttonsimpan.FlatStyle = FlatStyle.Flat;
            buttonsimpan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsimpan.ForeColor = Color.White;
            buttonsimpan.Location = new Point(179, 373);
            buttonsimpan.Name = "buttonsimpan";
            buttonsimpan.Size = new Size(131, 35);
            buttonsimpan.TabIndex = 1;
            buttonsimpan.Text = "Simpan";
            buttonsimpan.UseVisualStyleBackColor = false;
            buttonsimpan.Click += buttonsimpan_Click;
            // 
            // FormTambahBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(722, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTambahBarang";
            Text = "FormTambahBarang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonkembali;
        private Panel panel1;
        private Button buttonsimpan;
        private Label labeltambahbarang;
        private Label labelnamabarang;
        private DateTimePicker dateTimetglmasuk;
        private TextBox textBoxhargajual;
        private TextBox textBoxnamabarang;
        private Label labeltglmasuk;
        private Label labelhargajual;
        private TextBox textBoxkategori;
        private TextBox textBoxstok;
        private Label labelkategori;
        private Label labelstok;
        private TextBox textBoxidbarang;
        private Label labelidbarang;
        private TextBox textBoxhargabeli;
        private Label labelhargabeli;
    }
}