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
    public partial class RemoveItem : UserControl
    {
        Function fn = new Function();
        String query;


        public RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            DeleteLbl.Text = "How to DELETE?";
            DeleteLbl.ForeColor = Color.White;
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
            query = "select * from CSAPP_ADD_ITEMS where item_name like '" + TxtSearchItemName.Text + "%' ";
            DataSet ds = fn.GetData(query);
            dataGridShow.DataSource = ds.Tables[0];
        }

        private void dataGridShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?", "Warning Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                int id = int.Parse(dataGridShow.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from  CSAPP_ADD_ITEMS where ProductID = "+id+"";
                fn.SetData(query);
                LoadData();
            }
        }

        private void DeleteLbl_Click(object sender, EventArgs e)
        {
            DeleteLbl.ForeColor = Color.Gold;
            DeleteLbl.Text = "--> Click on Row to Delete Item.";
        }
    }
}
