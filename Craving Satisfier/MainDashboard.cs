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
    public partial class MainDashboard : Form
    {

        public MainDashboard()
        {
            InitializeComponent();
        }

        public MainDashboard(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                Menu_MenustripBtn.Available = true;
                RegisterMenubtn.Available = true;
                AdminMenubtn.Available = false;
                HomeMenuBtn.Available = true;
                
            }
            else if (user == "Admin")
            {
                Menu_MenustripBtn.Available = true;
                RegisterMenubtn.Available = false;
                AdminMenubtn.Available = true;
                HomeMenuBtn.Available = true;
            }
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Sign Out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();

            }
        }

        private void AddItemsBtn_Click(object sender, EventArgs e)
        {
            add_ItemsControlShow.Visible = true;
            add_ItemsControlShow.BringToFront();
        }

        private void purchaseItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            purchaseShow.Visible = true;
            purchaseShow.BringToFront();
        }

        private void riceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            riceControlShow.Visible = true;
            riceControlShow.BringToFront();
        }

        private void ValueMealsBtn_Click(object sender, EventArgs e)
        {
            valueMealControlShow.Visible = true;
            valueMealControlShow.BringToFront();
        }

        private void ComboMealBtn_Click(object sender, EventArgs e)
        {
            comboMealsControlShow.Visible = true;
            comboMealsControlShow.BringToFront();
        }

        private void cakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cakeControlShow.Visible = true;
            cakeControlShow.BringToFront();
        }

        private void iceCreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iceCreamControlShow.Visible = true;
            iceCreamControlShow.BringToFront();
        }

        private void filipinoStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filipinoStyleControlShow.Visible = true;
            filipinoStyleControlShow.BringToFront();
        }

        private void alcoholicDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alcoholDrinksControlShow.Visible = true;
            alcoholDrinksControlShow.BringToFront();
        }

        private void softDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softDrinksControlShow.Visible = true;
            softDrinksControlShow.BringToFront();
        }

        private void homeMadeDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homeMadeDrinksControlShow.Visible = true;
            homeMadeDrinksControlShow.BringToFront();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            add_ItemsControlShow.Visible = false;
            purchaseShow.Visible = false;
            updateItemControlShow.Visible = false;
            riceControlShow.Visible = false;
            valueMealControlShow.Visible = false;
            comboMealsControlShow.Visible = false;
            softDrinksControlShow.Visible = false;
            alcoholDrinksControlShow.Visible = false;
            homeMadeDrinksControlShow.Visible = false;
            removeItemControlShow.Visible = false;
            wingsControlShow.Visible = false;
            dimsumControlShow.Visible = false;
            porkBBQBtn.Visible = false;
            heavyLoadedControlShow.Visible = false;
            cakeControlShow.Visible = false;
            iceCreamControlShow.Visible = false;
            filipinoStyleControlShow.Visible = false;
            cold_CoffeeControlShow.Visible = false;
            hot_CoffeeControlShow.Visible = false;
            cheesy_LoadedControlShow.Visible = false;
            tableSchedulerControlShow.Visible = false;
            homePageControlShow.Visible = true;
            homePageControlShow.BringToFront();

        }

        private void RemoveItemsBtn_Click(object sender, EventArgs e)
        {
            removeItemControlShow.Visible = true;
            removeItemControlShow.BringToFront();
        }

        private void wingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wingsControlShow.Visible = true;
            wingsControlShow.BringToFront();
        }

        private void dimsumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dimsumControlShow.Visible = true;
            dimsumControlShow.BringToFront();
        }

        private void heavyLoadedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            heavyLoadedControlShow.Visible = true;
            heavyLoadedControlShow.BringToFront();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateItemControlShow.Visible = true;
            updateItemControlShow.BringToFront();
        }

        private void cheeseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheesy_LoadedControlShow.Visible = true;
            cheesy_LoadedControlShow.BringToFront();
        }

        private void hotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hot_CoffeeControlShow.Visible = true;
            hot_CoffeeControlShow.BringToFront();
        }

        private void coldCoffeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cold_CoffeeControlShow.Visible = true;
            cold_CoffeeControlShow.BringToFront();
        }

        private void HomePagebtn_Click(object sender, EventArgs e)
        {
            homePageControlShow.Visible = true;
            homePageControlShow.BringToFront();
        }

        private void porkBBQBtn_Click(object sender, EventArgs e)
        {
            pork_BBQControlShow.Visible = true;
            pork_BBQControlShow.BringToFront();
        }

        private void tablesAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableSchedulerControlShow.Visible = true;
            tableSchedulerControlShow.BringToFront();
        }
    }
}
