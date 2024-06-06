namespace Kel4_PBO.View
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartomzet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartbarangterlaku = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            labelomzet = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            labelomzetmingguan = new Label();
            labelpersen = new Label();
            labeltitleomzet = new Label();
            paneldropdown = new Panel();
            iconButton30 = new FontAwesome.Sharp.IconButton();
            iconButton15 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panel3 = new Panel();
            iconButtonselect = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)chartomzet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartbarangterlaku).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            paneldropdown.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chartomzet
            // 
            chartomzet.BackColor = SystemColors.WindowFrame;
            chartomzet.BorderlineColor = SystemColors.WindowFrame;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY.LabelStyle.Format = "Rp{0:0,}K";
            chartArea1.BackColor = SystemColors.WindowFrame;
            chartArea1.Name = "ChartArea1";
            chartomzet.ChartAreas.Add(chartArea1);
            legend1.BackColor = SystemColors.WindowFrame;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend1.ForeColor = Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = SystemColors.WindowFrame;
            chartomzet.Legends.Add(legend1);
            chartomzet.Location = new Point(12, 21);
            chartomzet.Name = "chartomzet";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = Color.FromArgb(107, 83, 255);
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = Color.FromArgb(241, 88, 127);
            series1.Legend = "Legend1";
            series1.MarkerColor = Color.Navy;
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            chartomzet.Series.Add(series1);
            chartomzet.Size = new Size(428, 245);
            chartomzet.TabIndex = 0;
            chartomzet.Text = "chartomzet";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.BackColor = SystemColors.WindowFrame;
            title1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.White;
            title1.Name = "Penjualan";
            title1.Text = "Penjualan";
            chartomzet.Titles.Add(title1);
            // 
            // chartbarangterlaku
            // 
            chartbarangterlaku.BackColor = SystemColors.WindowFrame;
            chartArea2.BackColor = SystemColors.WindowFrame;
            chartArea2.Name = "ChartArea1";
            chartbarangterlaku.ChartAreas.Add(chartArea2);
            legend2.BackColor = SystemColors.WindowFrame;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend2.ForeColor = Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chartbarangterlaku.Legends.Add(legend2);
            chartbarangterlaku.Location = new Point(455, 21);
            chartbarangterlaku.Name = "chartbarangterlaku";
            chartbarangterlaku.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chartbarangterlaku.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(241, 160, 139),
    Color.FromArgb(239, 188, 0),
    Color.FromArgb(241, 88, 127),
    Color.FromArgb(1, 220, 205),
    Color.FromArgb(94, 153, 254)
    };
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = Color.FromArgb(255, 159, 255);
            series2.BorderColor = SystemColors.WindowFrame;
            series2.BorderWidth = 7;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = Color.FromArgb(192, 192, 255);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartbarangterlaku.Series.Add(series2);
            chartbarangterlaku.Size = new Size(255, 485);
            chartbarangterlaku.TabIndex = 1;
            chartbarangterlaku.Text = "chartbarangterlaku";
            title2.Alignment = ContentAlignment.TopCenter;
            title2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.ForeColor = Color.White;
            title2.Name = "Penjualan";
            title2.Text = "Barang Terlaku";
            chartbarangterlaku.Titles.Add(title2);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(labelomzet);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelomzetmingguan);
            panel1.Controls.Add(labelpersen);
            panel1.Controls.Add(labeltitleomzet);
            panel1.Location = new Point(12, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 224);
            panel1.TabIndex = 2;
            // 
            // labelomzet
            // 
            labelomzet.AutoSize = true;
            labelomzet.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelomzet.ForeColor = SystemColors.ControlLightLight;
            labelomzet.Location = new Point(27, 70);
            labelomzet.Name = "labelomzet";
            labelomzet.Size = new Size(170, 37);
            labelomzet.TabIndex = 5;
            labelomzet.Text = "Rp2.459.500";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(38, 145);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(94, 173);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 3;
            label4.Text = "Minggu ini";
            // 
            // labelomzetmingguan
            // 
            labelomzetmingguan.AutoSize = true;
            labelomzetmingguan.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelomzetmingguan.ForeColor = SystemColors.ControlLightLight;
            labelomzetmingguan.Location = new Point(27, 173);
            labelomzetmingguan.Name = "labelomzetmingguan";
            labelomzetmingguan.Size = new Size(60, 19);
            labelomzetmingguan.TabIndex = 2;
            labelomzetmingguan.Text = "+546 rb";
            // 
            // labelpersen
            // 
            labelpersen.AutoSize = true;
            labelpersen.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelpersen.ForeColor = Color.Transparent;
            labelpersen.Location = new Point(80, 146);
            labelpersen.Name = "labelpersen";
            labelpersen.Size = new Size(56, 19);
            labelpersen.TabIndex = 1;
            labelpersen.Text = "+15,6%";
            // 
            // labeltitleomzet
            // 
            labeltitleomzet.AutoSize = true;
            labeltitleomzet.Font = new Font("Yu Gothic UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitleomzet.ForeColor = SystemColors.ControlLightLight;
            labeltitleomzet.Location = new Point(27, 45);
            labeltitleomzet.Name = "labeltitleomzet";
            labeltitleomzet.Size = new Size(67, 25);
            labeltitleomzet.TabIndex = 0;
            labeltitleomzet.Text = "Omzet";
            // 
            // paneldropdown
            // 
            paneldropdown.BackColor = Color.White;
            paneldropdown.Controls.Add(iconButton30);
            paneldropdown.Controls.Add(iconButton15);
            paneldropdown.Controls.Add(iconButton7);
            paneldropdown.Location = new Point(275, 30);
            paneldropdown.MaximumSize = new Size(145, 140);
            paneldropdown.MinimumSize = new Size(145, 35);
            paneldropdown.Name = "paneldropdown";
            paneldropdown.Size = new Size(145, 35);
            paneldropdown.TabIndex = 3;
            // 
            // iconButton30
            // 
            iconButton30.BackColor = Color.FromArgb(60, 60, 60);
            iconButton30.FlatAppearance.BorderSize = 0;
            iconButton30.FlatStyle = FlatStyle.Flat;
            iconButton30.ForeColor = Color.White;
            iconButton30.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton30.IconColor = Color.Black;
            iconButton30.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton30.Location = new Point(0, 105);
            iconButton30.Name = "iconButton30";
            iconButton30.Size = new Size(145, 35);
            iconButton30.TabIndex = 3;
            iconButton30.Text = "30 Hari";
            iconButton30.TextAlign = ContentAlignment.MiddleLeft;
            iconButton30.UseVisualStyleBackColor = false;
            iconButton30.Click += iconButton30_Click;
            // 
            // iconButton15
            // 
            iconButton15.BackColor = Color.FromArgb(60, 60, 60);
            iconButton15.FlatAppearance.BorderSize = 0;
            iconButton15.FlatStyle = FlatStyle.Flat;
            iconButton15.ForeColor = Color.White;
            iconButton15.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton15.IconColor = Color.Black;
            iconButton15.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton15.Location = new Point(0, 70);
            iconButton15.Name = "iconButton15";
            iconButton15.Size = new Size(145, 35);
            iconButton15.TabIndex = 2;
            iconButton15.Text = "15 Hari";
            iconButton15.TextAlign = ContentAlignment.MiddleLeft;
            iconButton15.UseVisualStyleBackColor = false;
            iconButton15.Click += iconButton15_Click;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(60, 60, 60);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton7.IconColor = Color.Black;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.Location = new Point(0, 35);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(145, 35);
            iconButton7.TabIndex = 1;
            iconButton7.Text = "7 Hari";
            iconButton7.TextAlign = ContentAlignment.MiddleLeft;
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Click += iconButton7_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Controls.Add(iconButtonselect);
            panel3.Location = new Point(275, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 35);
            panel3.TabIndex = 0;
            // 
            // iconButtonselect
            // 
            iconButtonselect.FlatAppearance.BorderSize = 0;
            iconButtonselect.FlatStyle = FlatStyle.Flat;
            iconButtonselect.ForeColor = Color.White;
            iconButtonselect.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            iconButtonselect.IconColor = Color.White;
            iconButtonselect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonselect.IconSize = 15;
            iconButtonselect.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonselect.Location = new Point(0, 0);
            iconButtonselect.Name = "iconButtonselect";
            iconButtonselect.Padding = new Padding(5, 0, 7, 0);
            iconButtonselect.Size = new Size(145, 35);
            iconButtonselect.TabIndex = 0;
            iconButtonselect.Text = "Select";
            iconButtonselect.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonselect.UseVisualStyleBackColor = true;
            iconButtonselect.Click += iconButtonselect_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(722, 530);
            Controls.Add(panel3);
            Controls.Add(paneldropdown);
            Controls.Add(panel1);
            Controls.Add(chartbarangterlaku);
            Controls.Add(chartomzet);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)chartomzet).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartbarangterlaku).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            paneldropdown.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartomzet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartbarangterlaku;
        private Panel panel1;
        private Label labelpersen;
        private Label labeltitleomzet;
        private Label label4;
        private Label labelomzetmingguan;
        private PictureBox pictureBox1;
        private Label labelomzet;
        private Panel paneldropdown;
        private FontAwesome.Sharp.IconButton buttonselect;
        private FontAwesome.Sharp.IconButton button7hari;
        private FontAwesome.Sharp.IconButton button15hari;
        private FontAwesome.Sharp.IconButton button30hari;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton30;
        private FontAwesome.Sharp.IconButton iconButton15;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButtonselect;
    }
}