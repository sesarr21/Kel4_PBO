using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kel4_PBO.Service;
using Microsoft.VisualBasic.ApplicationServices;

namespace Kel4_PBO.View
{
    public partial class Login : Form
    {
        private LoginService _loginService;
        private KotakMasukService _kotakMasukService;

        public Login()
        {
            InitializeComponent();
            _loginService = new LoginService("Host=localhost;Username=postgres;Password=444Ses@r;Database=kinkapp");
            _kotakMasukService = new KotakMasukService();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }


        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void labelSelamatDatang_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var (isAuthenticated, role, userId, karyawanId) = _loginService.AuthenticateUser(textBoxUsername.Text, textBoxPassword.Text);

            if (isAuthenticated)
            {
                // Simpan userId, role, dan karyawanId di Session
                Session.UserId = userId;
                Session.UserRole = role;
                Session.KaryawanId = karyawanId;

                bool hasLowStock = _kotakMasukService.GetBarangStokKurangDari(15).Count > 0;

                switch (role)
                {
                    case "admin":
                        var adminForm = new KinkAppAdmin();
                        adminForm.Show();
                        break;
                    case "karyawan":
                        var karyawanForm = new KinkAppKaryawan();
                        karyawanForm.Show();
                        break;
                    default:
                        MessageBox.Show("Role tidak dikenal.");
                        return;
                }

                if (hasLowStock)
                {
                    var messageBoxPesanForm = new MessageBoxPesan();
                    messageBoxPesanForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
        }
    }
}
