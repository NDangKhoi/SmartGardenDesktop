using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden
{
    public partial class Form_Home : Form
    {

        public Form_Home()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(childForm);
            panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panel_Desktop.Text = childForm.Text;


        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Login());
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Sign Out ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (reset)
            {
                case DialogResult.Yes:
                    Application.Restart();
                    break;
            }
        }
    }
}
