using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace SmartGarden
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
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
        private void _Show()
        {
            OpenChildForm(new Form_Control());
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                //perform on the UI thread
                _Show();
            }));

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
        
        private void btn_History_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Form_History());

        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Chart());
        }
    }
}
