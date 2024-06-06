namespace Kel4_PBO.View
{
    partial class FormDataBarang
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
            iconButtontambah = new FontAwesome.Sharp.IconButton();
            textBoxsearch = new TextBox();
            dataGridView1 = new DataGridView();
            iconButtonsearch = new FontAwesome.Sharp.IconButton();
            paneldatabarang = new Panel();
            btnprev = new FontAwesome.Sharp.IconButton();
            btnnext = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            paneldatabarang.SuspendLayout();
            SuspendLayout();
            // 
            // iconButtontambah
            // 
            iconButtontambah.BackColor = Color.FromArgb(35, 35, 35);
            iconButtontambah.FlatAppearance.BorderSize = 0;
            iconButtontambah.FlatStyle = FlatStyle.Flat;
            iconButtontambah.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            iconButtontambah.ForeColor = Color.White;
            iconButtontambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButtontambah.IconColor = Color.FromArgb(255, 102, 36);
            iconButtontambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtontambah.IconSize = 20;
            iconButtontambah.Location = new Point(29, 22);
            iconButtontambah.Name = "iconButtontambah";
            iconButtontambah.Size = new Size(139, 36);
            iconButtontambah.TabIndex = 2;
            iconButtontambah.Text = "Tambah";
            iconButtontambah.TextAlign = ContentAlignment.MiddleLeft;
            iconButtontambah.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtontambah.UseVisualStyleBackColor = false;
            iconButtontambah.Click += iconButtontambah_Click;
            // 
            // textBoxsearch
            // 
            textBoxsearch.BackColor = Color.FromArgb(35, 35, 35);
            textBoxsearch.Font = new Font("Segoe UI", 16F);
            textBoxsearch.ForeColor = Color.White;
            textBoxsearch.Location = new Point(392, 22);
            textBoxsearch.Name = "textBoxsearch";
            textBoxsearch.Size = new Size(256, 36);
            textBoxsearch.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(619, 275);
            dataGridView1.TabIndex = 6;
            // 
            // iconButtonsearch
            // 
            iconButtonsearch.BackColor = Color.FromArgb(35, 35, 35);
            iconButtonsearch.FlatAppearance.BorderSize = 0;
            iconButtonsearch.FlatStyle = FlatStyle.Flat;
            iconButtonsearch.Font = new Font("Segoe UI", 6F);
            iconButtonsearch.ForeColor = Color.FromArgb(255, 102, 36);
            iconButtonsearch.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonsearch.IconColor = Color.Black;
            iconButtonsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonsearch.Location = new Point(545, 31);
            iconButtonsearch.Name = "iconButtonsearch";
            iconButtonsearch.Size = new Size(97, 18);
            iconButtonsearch.TabIndex = 7;
            iconButtonsearch.Text = "Search by ID";
            iconButtonsearch.UseVisualStyleBackColor = false;
            iconButtonsearch.Click += iconButtonsearch_Click;
            // 
            // paneldatabarang
            // 
            paneldatabarang.BackColor = Color.White;
            paneldatabarang.Controls.Add(iconButtonsearch);
            paneldatabarang.Controls.Add(iconButtontambah);
            paneldatabarang.Controls.Add(btnprev);
            paneldatabarang.Controls.Add(btnnext);
            paneldatabarang.Controls.Add(textBoxsearch);
            paneldatabarang.Location = new Point(39, 24);
            paneldatabarang.Name = "paneldatabarang";
            paneldatabarang.Size = new Size(668, 457);
            paneldatabarang.TabIndex = 8;
            // 
            // btnprev
            // 
            btnprev.BackColor = Color.FromArgb(35, 35, 35);
            btnprev.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnprev.FlatAppearance.BorderSize = 0;
            btnprev.FlatStyle = FlatStyle.Flat;
            btnprev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnprev.ForeColor = Color.FromArgb(255, 102, 36);
            btnprev.IconChar = FontAwesome.Sharp.IconChar.None;
            btnprev.IconColor = Color.Black;
            btnprev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnprev.Location = new Point(528, 387);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(57, 48);
            btnprev.TabIndex = 2;
            btnprev.Text = "<";
            btnprev.UseVisualStyleBackColor = false;
            btnprev.Click += btnprev_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.FromArgb(35, 35, 35);
            btnnext.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnnext.FlatAppearance.BorderSize = 0;
            btnnext.FlatStyle = FlatStyle.Flat;
            btnnext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnext.ForeColor = Color.FromArgb(255, 102, 36);
            btnnext.IconChar = FontAwesome.Sharp.IconChar.None;
            btnnext.IconColor = Color.Black;
            btnnext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnext.Location = new Point(591, 387);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(57, 48);
            btnnext.TabIndex = 1;
            btnnext.Text = ">";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // FormDataBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(722, 530);
            Controls.Add(dataGridView1);
            Controls.Add(paneldatabarang);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDataBarang";
            Text = "Data Barang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            paneldatabarang.ResumeLayout(false);
            paneldatabarang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtontambah;
        private TextBox textBoxsearch;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonsearch;
        private Panel paneldatabarang;
        private FontAwesome.Sharp.IconButton btnnext;
        private FontAwesome.Sharp.IconButton btnprev;
    }
}