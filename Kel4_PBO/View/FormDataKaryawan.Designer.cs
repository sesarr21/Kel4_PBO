namespace Kel4_PBO.View
{
    partial class FormDataKaryawan
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
        //@ -28,34 +28,358 @@//
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            buttonhapus = new Button();
            buttontambah = new Button();
            dataGridViewNamaKaryawan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            txtalamat = new TextBox();
            txtnama = new TextBox();
            labelpassword = new Label();
            labelusername = new Label();
            labeltanggalpendaftaran = new Label();
            labelalamat = new Label();
            labelnama = new Label();
            panel1 = new Panel();
            idAkun = new Label();
            textidAkun = new TextBox();
            idKaryawan = new Label();
            textidKaryawan = new TextBox();
            dateTimePendaftaran = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamaKaryawan).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonhapus
            // 
            buttonhapus.Anchor = AnchorStyles.None;
            buttonhapus.BackColor = Color.FromArgb(255, 102, 36);
            buttonhapus.FlatAppearance.BorderSize = 0;
            buttonhapus.FlatStyle = FlatStyle.Flat;
            buttonhapus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonhapus.ForeColor = Color.White;
            buttonhapus.Location = new Point(552, 377);
            buttonhapus.Margin = new Padding(3, 2, 3, 2);
            buttonhapus.Name = "buttonhapus";
            buttonhapus.Size = new Size(80, 28);
            buttonhapus.TabIndex = 43;
            buttonhapus.Text = "Hapus";
            buttonhapus.UseVisualStyleBackColor = false;
            buttonhapus.Click += buttonhapus_Click;
            // 
            // buttontambah
            // 
            buttontambah.Anchor = AnchorStyles.None;
            buttontambah.BackColor = Color.FromArgb(255, 102, 36);
            buttontambah.FlatAppearance.BorderSize = 0;
            buttontambah.FlatStyle = FlatStyle.Flat;
            buttontambah.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttontambah.ForeColor = Color.White;
            buttontambah.Location = new Point(452, 377);
            buttontambah.Margin = new Padding(3, 2, 3, 2);
            buttontambah.Name = "buttontambah";
            buttontambah.Size = new Size(80, 28);
            buttontambah.TabIndex = 35;
            buttontambah.Text = "Tambah";
            buttontambah.UseVisualStyleBackColor = false;
            buttontambah.Click += buttonadd_Click;
            // 
            // dataGridViewNamaKaryawan
            // 
            dataGridViewNamaKaryawan.Anchor = AnchorStyles.None;
            dataGridViewNamaKaryawan.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewNamaKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNamaKaryawan.Columns.AddRange(new DataGridViewColumn[] { Column1, alamat, Column3, Column4, Column5 });
            dataGridViewNamaKaryawan.GridColor = SystemColors.InactiveCaptionText;
            dataGridViewNamaKaryawan.Location = new Point(22, 248);
            dataGridViewNamaKaryawan.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNamaKaryawan.Name = "dataGridViewNamaKaryawan";
            dataGridViewNamaKaryawan.RowHeadersWidth = 51;
            dataGridViewNamaKaryawan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewNamaKaryawan.Size = new Size(610, 108);
            dataGridViewNamaKaryawan.TabIndex = 37;
            dataGridViewNamaKaryawan.CellContentClick += dataGridViewNamaKaryawan_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Nama Karyawan";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 108;
            // 
            // alamat
            // 
            alamat.HeaderText = "Alamat";
            alamat.MinimumWidth = 8;
            alamat.Name = "alamat";
            alamat.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Username";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Password";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "Tanggal Pendaftaran";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 128;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.ForeColor = SystemColors.InfoText;
            txtpassword.Location = new Point(361, 135);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(271, 23);
            txtpassword.TabIndex = 34;
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.None;
            txtusername.ForeColor = SystemColors.InfoText;
            txtusername.Location = new Point(361, 88);
            txtusername.Margin = new Padding(3, 2, 3, 2);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(273, 23);
            txtusername.TabIndex = 33;
            // 
            // txtalamat
            // 
            txtalamat.Anchor = AnchorStyles.None;
            txtalamat.ForeColor = SystemColors.InfoText;
            txtalamat.Location = new Point(22, 135);
            txtalamat.Margin = new Padding(3, 2, 3, 2);
            txtalamat.Name = "txtalamat";
            txtalamat.Size = new Size(262, 23);
            txtalamat.TabIndex = 31;
            // 
            // txtnama
            // 
            txtnama.Anchor = AnchorStyles.None;
            txtnama.ForeColor = SystemColors.InfoText;
            txtnama.Location = new Point(22, 88);
            txtnama.Margin = new Padding(3, 2, 3, 2);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(262, 23);
            txtnama.TabIndex = 30;
            // 
            // labelpassword
            // 
            labelpassword.Anchor = AnchorStyles.None;
            labelpassword.AutoSize = true;
            labelpassword.BackColor = Color.White;
            labelpassword.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelpassword.ForeColor = SystemColors.ActiveCaptionText;
            labelpassword.Location = new Point(361, 109);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(57, 16);
            labelpassword.TabIndex = 29;
            labelpassword.Text = "Password";
            // 
            // labelusername
            // 
            labelusername.Anchor = AnchorStyles.None;
            labelusername.AutoSize = true;
            labelusername.BackColor = Color.White;
            labelusername.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusername.ForeColor = SystemColors.ActiveCaptionText;
            labelusername.Location = new Point(361, 64);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(60, 16);
            labelusername.TabIndex = 28;
            labelusername.Text = "Username";
            // 
            // labeltanggalpendaftaran
            // 
            labeltanggalpendaftaran.Anchor = AnchorStyles.None;
            labeltanggalpendaftaran.AutoSize = true;
            labeltanggalpendaftaran.BackColor = Color.White;
            labeltanggalpendaftaran.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltanggalpendaftaran.ForeColor = SystemColors.ActiveCaptionText;
            labeltanggalpendaftaran.Location = new Point(22, 166);
            labeltanggalpendaftaran.Name = "labeltanggalpendaftaran";
            labeltanggalpendaftaran.Size = new Size(117, 16);
            labeltanggalpendaftaran.TabIndex = 27;
            labeltanggalpendaftaran.Text = "Tanggal Pendaftaran";
            // 
            // labelalamat
            // 
            labelalamat.Anchor = AnchorStyles.None;
            labelalamat.AutoSize = true;
            labelalamat.BackColor = Color.White;
            labelalamat.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelalamat.ForeColor = SystemColors.ActiveCaptionText;
            labelalamat.Location = new Point(22, 109);
            labelalamat.Name = "labelalamat";
            labelalamat.Size = new Size(45, 16);
            labelalamat.TabIndex = 25;
            labelalamat.Text = "Alamat";
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.None;
            labelnama.AutoSize = true;
            labelnama.BackColor = Color.White;
            labelnama.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnama.ForeColor = SystemColors.ActiveCaptionText;
            labelnama.Location = new Point(22, 64);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(39, 16);
            labelnama.TabIndex = 24;
            labelnama.Text = "Nama";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(idAkun);
            panel1.Controls.Add(textidAkun);
            panel1.Controls.Add(idKaryawan);
            panel1.Controls.Add(textidKaryawan);
            panel1.Controls.Add(dateTimePendaftaran);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(buttonhapus);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(labeltanggalpendaftaran);
            panel1.Controls.Add(txtnama);
            panel1.Controls.Add(labelalamat);
            panel1.Controls.Add(txtalamat);
            panel1.Controls.Add(labelnama);
            panel1.Controls.Add(buttontambah);
            panel1.Controls.Add(labelusername);
            panel1.Controls.Add(labelpassword);
            panel1.Controls.Add(dataGridViewNamaKaryawan);
            panel1.Location = new Point(45, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 457);
            panel1.TabIndex = 46;
            // 
            // idAkun
            // 
            idAkun.Anchor = AnchorStyles.None;
            idAkun.AutoSize = true;
            idAkun.BackColor = Color.White;
            idAkun.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idAkun.ForeColor = SystemColors.ActiveCaptionText;
            idAkun.Location = new Point(361, 20);
            idAkun.Name = "idAkun";
            idAkun.Size = new Size(49, 16);
            idAkun.TabIndex = 50;
            idAkun.Text = "ID Akun";
            // 
            // textidAkun
            // 
            textidAkun.Anchor = AnchorStyles.None;
            textidAkun.ForeColor = SystemColors.InfoText;
            textidAkun.Location = new Point(361, 43);
            textidAkun.Margin = new Padding(3, 2, 3, 2);
            textidAkun.Name = "textidAkun";
            textidAkun.Size = new Size(273, 23);
            textidAkun.TabIndex = 49;
            // 
            // idKaryawan
            // 
            idKaryawan.Anchor = AnchorStyles.None;
            idKaryawan.AutoSize = true;
            idKaryawan.BackColor = Color.White;
            idKaryawan.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idKaryawan.ForeColor = SystemColors.ActiveCaptionText;
            idKaryawan.Location = new Point(22, 20);
            idKaryawan.Name = "idKaryawan";
            idKaryawan.Size = new Size(72, 16);
            idKaryawan.TabIndex = 48;
            idKaryawan.Text = "ID Karyawan";
            // 
            // textidKaryawan
            // 
            textidKaryawan.Anchor = AnchorStyles.None;
            textidKaryawan.ForeColor = SystemColors.InfoText;
            textidKaryawan.Location = new Point(22, 43);
            textidKaryawan.Margin = new Padding(3, 2, 3, 2);
            textidKaryawan.Name = "textidKaryawan";
            textidKaryawan.Size = new Size(262, 23);
            textidKaryawan.TabIndex = 47;
            // 
            // dateTimePendaftaran
            // 
            dateTimePendaftaran.Location = new Point(22, 196);
            dateTimePendaftaran.Margin = new Padding(2, 2, 2, 2);
            dateTimePendaftaran.Name = "dateTimePendaftaran";
            dateTimePendaftaran.Size = new Size(262, 23);
            dateTimePendaftaran.TabIndex = 46;
            // 
            // FormDataKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(722, 530);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDataKaryawan";
            Text = "Data Karyawan";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNamaKaryawan).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonhapus;
        private Button buttontambah;
        private DataGridView dataGridViewNamaKaryawan;
        private TextBox txtpassword;
        private TextBox txtusername;
        private TextBox txtalamat;
        private TextBox txtnama;
        private Label labelpassword;
        private Label labelusername;
        private Label labeltanggalpendaftaran;
        private Label labelalamat;
        private Label labelnama;
        private Panel panel1;
        private DateTimePicker dateTimePendaftaran;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label idKaryawan;
        private TextBox textidKaryawan;
        private TextBox textidAkun;
        private Label idAkun;
    }
}