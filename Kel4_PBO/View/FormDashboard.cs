using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Kel4_PBO.Service;
using Npgsql;

namespace Kel4_PBO.View
{
    public partial class Dashboard : Form
    {
        private DashboardService _dashboardService;
        public Dashboard()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            LoadOmzet();
            LoadDoughnutChart();
            UpdateOmzetMingguan();
            LoadSplineChart(30);
        }
        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                paneldropdown.Height += 15;
                if (paneldropdown.Height >= paneldropdown.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                paneldropdown.Height -= 15;
                if (paneldropdown.Height <= paneldropdown.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void LoadOmzet()
        {
            try
            {
                decimal totalOmzet = _dashboardService.GetTotalOmzetLast30Days();
                labelomzet.Text = $"Rp{totalOmzet:N}"; // Menggunakan format N untuk angka dengan koma ribuan
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void iconButtonselect_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void LoadDoughnutChart()
        {
            try
            {
                List<KeyValuePair<string, int>> data = _dashboardService.GetTop5BarangTerlaku();

                // Bersihkan chart sebelum menambahkan data baru
                chartbarangterlaku.Series.Clear();
                chartbarangterlaku.ChartAreas.Clear();
                chartbarangterlaku.Legends.Clear();
                chartbarangterlaku.Titles.Clear();

                // Set chart properties
                chartbarangterlaku.BackColor = SystemColors.WindowFrame;

                // Set chart area properties
                ChartArea chartArea4 = new ChartArea();
                chartArea4.BackColor = SystemColors.WindowFrame;
                chartArea4.Name = "ChartArea1";
                chartbarangterlaku.ChartAreas.Add(chartArea4);

                // Set legend properties
                Legend legend4 = new Legend();
                legend4.BackColor = SystemColors.WindowFrame;
                legend4.Docking = Docking.Bottom;
                legend4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                legend4.ForeColor = Color.White;
                legend4.IsTextAutoFit = false;
                legend4.Name = "Legend1";
                chartbarangterlaku.Legends.Add(legend4);

                // Set series properties
                Series series4 = new Series();
                series4.BackGradientStyle = GradientStyle.LeftRight;
                series4.BackSecondaryColor = Color.FromArgb(255, 159, 255);
                series4.BorderColor = SystemColors.WindowFrame;
                series4.BorderWidth = 7;
                series4.ChartArea = "ChartArea1";
                series4.ChartType = SeriesChartType.Doughnut;
                series4.Color = Color.FromArgb(192, 192, 255);
                series4.Legend = "Legend1";
                series4.Name = "Series1";

                // Add data points to series
                foreach (var point in data)
                {
                    series4.Points.AddXY(point.Key, point.Value);
                }

                chartbarangterlaku.Series.Add(series4);

                // Set custom palette colors
                chartbarangterlaku.Palette = ChartColorPalette.None;
                chartbarangterlaku.PaletteCustomColors = new Color[]
                {
            Color.FromArgb(241, 160, 139),
            Color.FromArgb(239, 188, 0),
            Color.FromArgb(241, 88, 127),
            Color.FromArgb(1, 220, 205),
            Color.FromArgb(94, 153, 254)
                };

                // Set title properties
                Title title4 = new Title();
                title4.Alignment = ContentAlignment.TopCenter;
                title4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                title4.ForeColor = Color.White;
                title4.Name = "Penjualan";
                title4.Text = "Barang Terlaku";
                chartbarangterlaku.Titles.Add(title4);

                // Set chart size and location (if needed)
                chartbarangterlaku.Location = new Point(455, 21);
                chartbarangterlaku.Size = new Size(255, 485);
                chartbarangterlaku.TabIndex = 1;
                chartbarangterlaku.Text = "chartbarangterlaku";

                // Invalidate chart to refresh
                chartbarangterlaku.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSplineChart(int days)
        {
            try
            {
                List<KeyValuePair<DateTime, decimal>> data = _dashboardService.GetTransaksiData(days);

                // Bersihkan chart sebelum menambahkan data baru
                chartomzet.Series.Clear();
                chartomzet.ChartAreas.Clear();
                chartomzet.Legends.Clear();
                chartomzet.Titles.Clear();

                // Konfigurasi chart area
                ChartArea chartArea1 = new ChartArea();
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

                // Konfigurasi legend
                Legend legend1 = new Legend();
                legend1.BackColor = SystemColors.WindowFrame;
                legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
                legend1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                legend1.ForeColor = Color.White;
                legend1.IsTextAutoFit = false;
                legend1.Name = "Legend1";
                legend1.TitleBackColor = SystemColors.WindowFrame;
                chartomzet.Legends.Add(legend1);

                // Konfigurasi series
                Series series1 = new Series();
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

                foreach (var point in data)
                {
                    series1.Points.AddXY(point.Key, point.Value);
                }

                chartomzet.Series.Add(series1);

                // Konfigurasi title
                Title title1 = new Title();
                title1.Alignment = ContentAlignment.TopLeft;
                title1.BackColor = SystemColors.WindowFrame;
                title1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                title1.ForeColor = Color.White;
                title1.Name = "Penjualan";
                title1.Text = "Penjualan";
                chartomzet.Titles.Add(title1);

                // Atur skala sumbu X agar sesuai dengan data
                if (data.Count > 0)
                {
                    chartomzet.ChartAreas[0].AxisX.Minimum = data[0].Key.ToOADate();
                    chartomzet.ChartAreas[0].AxisX.Maximum = data[data.Count - 1].Key.ToOADate();
                }

                // Invalidate chart agar di-refresh
                chartomzet.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void iconButton7_Click(object sender, EventArgs e)
        {
            LoadSplineChart(7);
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            LoadSplineChart(15);
        }

        private void iconButton30_Click(object sender, EventArgs e)
        {
            LoadSplineChart(30);
        }

        private void UpdateOmzetMingguan()
        {
            try
            {
                decimal omzetMingguIni = _dashboardService.GetOmzetMingguIni();
                decimal omzetMingguLalu = _dashboardService.GetOmzetMingguLalu();

                decimal perubahan = omzetMingguIni - omzetMingguLalu;
                decimal persenPerubahan = omzetMingguLalu != 0 ? (perubahan / omzetMingguLalu) * 100 : 0;

                // Menggunakan pembulatan ke ribuan terdekat
                string perubahanText = perubahan >= 0 ? $"+{Math.Round(perubahan / 1000, 0)} rb" : $"-{Math.Abs(Math.Round(perubahan / 1000, 0))} rb";
                string persenText = persenPerubahan >= 0 ? $"+{Math.Round(persenPerubahan, 0)}%" : $"-{Math.Abs(Math.Round(persenPerubahan, 0))}%";

                labelomzetmingguan.Text = perubahanText;
                labelpersen.Text = persenText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}