using Kel4_PBO.Service;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Kel4_PBO.View
{
    public partial class FormKotakMasuk : Form
    {
        private KotakMasukService kotakMasukService;
        private List<Panel> panels;
        private List<Label> labels;
        private List<CheckBox> checkboxes;

        public FormKotakMasuk()
        {
            InitializeComponent();
            kotakMasukService = new KotakMasukService();

            // Initialize lists for easier management
            panels = new List<Panel> { panelpesan1, panelpesan2, panelpesan3, panelpesan4 };
            labels = new List<Label> { labelpesan1, labelpesan2, labelpesan3, labelpesan4 };
            checkboxes = new List<CheckBox> { checkBox1, checkBox2, checkBox3, checkBox4 };

            UpdateStokInfo();
        }

        private void UpdateStokInfo()
        {
            var barangStokList = kotakMasukService.GetBarangStokKurangDari(15);

            // Initialize panel and label visibility
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Visible = false;
                checkboxes[i].Checked = false;
            }

            // Update panels and labels based on the number of items with low stock
            if (barangStokList.Count > 0)
            {
                for (int i = 0; i < barangStokList.Count && i < 4; i++)
                {
                    var barangStok = barangStokList[i];
                    labels[i].Text = $"{barangStok.IdBarang} sisa {barangStok.TotalStok}";
                    panels[i].Visible = true;
                }
            }
        }

        private void buttonread_Click(object sender, EventArgs e)
        {
            // Remove messages where the checkbox is checked and shift remaining messages up
            for (int i = 0; i < panels.Count; i++)
            {
                if (checkboxes[i].Checked)
                {
                    // Update is_read status in the database
                    var idBarang = labels[i].Text.Split(' ')[0];
                    kotakMasukService.MarkBarangAsRead(idBarang);

                    // Shift messages up
                    for (int j = i; j < panels.Count - 1; j++)
                    {
                        labels[j].Text = labels[j + 1].Text;
                        checkboxes[j].Checked = checkboxes[j + 1].Checked;
                        panels[j].Visible = panels[j + 1].Visible;
                    }

                    // Hide the last panel as it's been moved up
                    panels[panels.Count - 1].Visible = false;
                    checkboxes[panels.Count - 1].Checked = false;
                    break;  // Exit the loop after handling one checked checkbox
                }
            }
        }

        private void buttonallread_Click(object sender, EventArgs e)
        {
            // Mark all messages as read in the database
            kotakMasukService.MarkAllBarangAsRead();

            // Hide all panels
            for (int i = 0; i < panels.Count; i++)
            {
                panels[i].Visible = false;
                checkboxes[i].Checked = false;
            }

            // Optionally, refresh the data from the service
            UpdateStokInfo();
        }
    }

}
