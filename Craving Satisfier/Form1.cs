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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingTime_Tick(object sender, EventArgs e)
        {
            Loader.Width += 1;

            if (Loader.Width >= 441)
            {
                LoadingTime.Stop();
                Login lg = new Login();
                lg.Show();
                this.Hide();

            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
