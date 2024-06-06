namespace Kel4_PBO.View
{
    partial class MessageBoxPesan
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
            labelmsg = new Label();
            buttontutup = new Button();
            SuspendLayout();
            // 
            // labelmsg
            // 
            labelmsg.AutoSize = true;
            labelmsg.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelmsg.ForeColor = Color.White;
            labelmsg.Location = new Point(35, 40);
            labelmsg.Name = "labelmsg";
            labelmsg.Size = new Size(414, 25);
            labelmsg.TabIndex = 0;
            labelmsg.Text = "Stok barang menipis, silahkan cek kotak masuk";
            // 
            // buttontutup
            // 
            buttontutup.FlatAppearance.BorderSize = 3;
            buttontutup.FlatStyle = FlatStyle.Flat;
            buttontutup.ForeColor = Color.FromArgb(255, 102, 36);
            buttontutup.Location = new Point(191, 77);
            buttontutup.Name = "buttontutup";
            buttontutup.Size = new Size(103, 35);
            buttontutup.TabIndex = 1;
            buttontutup.Text = "Tutup";
            buttontutup.UseVisualStyleBackColor = true;
            buttontutup.Click += buttontutup_Click;
            // 
            // MessageBoxPesan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(484, 146);
            Controls.Add(buttontutup);
            Controls.Add(labelmsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxPesan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxPesan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelmsg;
        private Button buttontutup;
    }
}