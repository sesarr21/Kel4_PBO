namespace Kel4_PBO.View
{
    partial class FormTransaksi
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
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            lblHarga = new Label();
            lblNama = new Label();
            lblJmlStok = new Label();
            label6 = new Label();
            btnNext = new Button();
            label12 = new Label();
            panel4 = new Panel();
            lblKembalian = new Label();
            label10 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            lblTotal = new Label();
            tbUangDiterima = new TextBox();
            btnPrint = new Button();
            label8 = new Label();
            btnAdd = new Button();
            tbJml = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBoxidbarang = new TextBox();
            label2 = new Label();
            panelContent = new Panel();
            dataGriddetail = new DataGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriddetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(344, 200);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "transaksi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 118);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGriddetail);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(lblHarga);
            panel2.Controls.Add(lblNama);
            panel2.Controls.Add(lblJmlStok);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tbUangDiterima);
            panel2.Controls.Add(btnPrint);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(tbJml);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxidbarang);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(12, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(698, 408);
            panel2.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 102, 36);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(208, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.White;
            lblHarga.ForeColor = Color.Black;
            lblHarga.Location = new Point(137, 112);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(39, 15);
            lblHarga.TabIndex = 29;
            lblHarga.Text = "Harga";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.White;
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(137, 83);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(39, 15);
            lblNama.TabIndex = 28;
            lblNama.Text = "Nama";
            // 
            // lblJmlStok
            // 
            lblJmlStok.AutoSize = true;
            lblJmlStok.BackColor = Color.White;
            lblJmlStok.ForeColor = Color.Black;
            lblJmlStok.Location = new Point(137, 140);
            lblJmlStok.Name = "lblJmlStok";
            lblJmlStok.Size = new Size(45, 15);
            lblJmlStok.TabIndex = 27;
            lblJmlStok.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(32, 142);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 26;
            label6.Text = "Stok";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 102, 36);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(579, 252);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 25;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(32, 112);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 22;
            label12.Text = "Harga Barang";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(lblKembalian);
            panel4.ForeColor = Color.DarkGray;
            panel4.Location = new Point(391, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 25);
            panel4.TabIndex = 19;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.BackColor = Color.DarkGray;
            lblKembalian.Font = new Font("Segoe UI", 12F);
            lblKembalian.ForeColor = Color.Black;
            lblKembalian.Location = new Point(4, 2);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(83, 21);
            lblKembalian.TabIndex = 1;
            lblKembalian.Text = "Kembalian";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(489, 311);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 20;
            label10.Text = "KEMBALIAN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.ForeColor = Color.White;
            label9.Location = new Point(494, 283);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 19;
            label9.Text = "PAYMENT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(lblTotal);
            panel3.ForeColor = Color.DarkGray;
            panel3.Location = new Point(391, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 25);
            panel3.TabIndex = 18;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(3, 2);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(88, 21);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Harga";
            // 
            // tbUangDiterima
            // 
            tbUangDiterima.Location = new Point(391, 253);
            tbUangDiterima.Name = "tbUangDiterima";
            tbUangDiterima.Size = new Size(182, 23);
            tbUangDiterima.TabIndex = 17;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(255, 102, 36);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(579, 373);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 122);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 102, 36);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(119, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbJml
            // 
            tbJml.Location = new Point(32, 195);
            tbJml.Name = "tbJml";
            tbJml.Size = new Size(251, 23);
            tbJml.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 170);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(32, 82);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 2;
            label4.Text = "Nama Barang";
            // 
            // textBoxidbarang
            // 
            textBoxidbarang.Location = new Point(32, 47);
            textBoxidbarang.Name = "textBoxidbarang";
            textBoxidbarang.Size = new Size(170, 23);
            textBoxidbarang.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 29);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "ID Barang";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(35, 35, 35);
            panelContent.Controls.Add(panel2);
            panelContent.Controls.Add(label3);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(722, 530);
            panelContent.TabIndex = 5;
            // 
            // dataGriddetail
            // 
            dataGriddetail.BackgroundColor = Color.White;
            dataGriddetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriddetail.Location = new Point(391, 29);
            dataGriddetail.Name = "dataGriddetail";
            dataGriddetail.Size = new Size(263, 187);
            dataGriddetail.TabIndex = 31;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(722, 530);
            Controls.Add(panelContent);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransaksi";
            Text = "Transaksi";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGriddetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNama;
        private Button btnSearch;
        private Label lblHarga;
        private Label label3;
        private Panel panel2;
        private Label lblJmlStok;
        private Label label6;
        private Button btnNext;
        private Label label12;
        private Panel panel4;
        private Label lblKembalian;
        private Label label10;
        private Label label9;
        private Panel panel3;
        private Label lblTotal;
        private TextBox tbUangDiterima;
        private Button btnPrint;
        private Label label8;
        private Button btnAdd;
        private TextBox tbJml;
        private Label label5;
        private Label label4;
        private TextBox textBoxidbarang;
        private Label label2;
        private Panel panelContent;
        private DataGridView dataGriddetail;
    }
}