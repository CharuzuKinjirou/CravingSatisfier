using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craving_Satisfier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Guestlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainDashboard md = new MainDashboard("Guest");
            md.Show();
            this.Hide();

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "CravingSatisfier" && txtPassword.Text == "12345")
            {
                MainDashboard md = new MainDashboard("Admin");
                md.Show();
                this.Hide();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the Application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
