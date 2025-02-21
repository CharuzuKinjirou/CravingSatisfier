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
    public partial class Add_Items : UserControl
    {
        Function fn = new Function();
        String query;

        public Add_Items()
        {
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            query = "insert into CSAPP_ADD_ITEMS (item_name,category,price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.SetData(query);
            clearAll();
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void Add_Items_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
