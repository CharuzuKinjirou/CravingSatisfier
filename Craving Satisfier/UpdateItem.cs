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
    public partial class UpdateItem : UserControl
    {
        Function fn = new Function();
        String query;

        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            query = "select * from CSAPP_ADD_ITEMS";
            DataSet ds = fn.GetData(query);
            dataGridShow.DataSource = ds.Tables[0];
        }

        private void TxtSearchItemName_TextChange(object sender, EventArgs e)
        {
            query = "select * from CSAPP_ADD_ITEMS where item_name like '"+ TxtSearchItemName.Text +"%' ";
            DataSet ds = fn.GetData(query);
            dataGridShow.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridShow.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = dataGridShow.Rows[e.RowIndex].Cells[1].Value.ToString();
            String category = dataGridShow.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(dataGridShow.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtItemName.Text = name;
            txtCategory.Text = category;
            txtPrice.Text = price.ToString();

        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            query = "update CSAPP_ADD_ITEMS set item_name = '" + txtItemName.Text + "', category = '" + txtCategory.Text + "', price = " + txtPrice.Text + " where ProductID = " + id + " ";
            fn.SetData(query);
            LoadData();

            txtItemName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }
    }
}
