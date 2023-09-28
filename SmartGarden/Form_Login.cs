using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FirebaseAdmin.Auth;

namespace SmartGarden
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        #region Set up
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
       
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool ReleaseCapture();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
        #endregion
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                MessageBox.Show("Invalid Email");
                txtEmail.Focus();
                return;
            }
            if(txtPassword.Text == "")
            {
                MessageBox.Show("Invalid Password");
                txtPassword.Focus();
                return;
            }
            MessageBox.Show("Successfully Login");

            this.Hide();
            _Show();
            this.Close();
        }
        private void _Show()
        {
            Form_Home form_Home = new Form_Home();
            form_Home.ShowDialog();
        }
        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://ndangkhoi.github.io/My-garden/html/forgotpage.html");
        }

        private void pic_hide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pic_hide.Hide();
            pic_visible.Show();
        }

        private void pic_visible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pic_hide.Show();
            pic_visible.Hide();
        }

        void Start()
        {
            
        }
    }
}
