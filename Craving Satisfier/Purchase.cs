using DGVPrinterHelper;
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
    public partial class Purchase : UserControl
    {
        Function fn = new Function();
        String query;

        public Purchase()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select item_name from CSAPP_ADD_ITEMS where category = '" + category + "'";

            showItemList(query);
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select item_name from CSAPP_ADD_ITEMS where category = '" + category + "' and item_name like '"+txtSearch.Text+"%' ";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox.Items.Clear();
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotalPrice.Clear();

            String text = listBox.GetItemText(listBox.SelectedItem);
            txtProductName.Text = text;
            query = "select price from CSAPP_ADD_ITEMS where item_name = '"+text+"' ";
            DataSet ds = fn.GetData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);

            txtTotalPrice.Text = (quan * price).ToString();

        }

        protected int n, total = 0;
        private void AddtoCartBtn_Click(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text != "0" && txtTotalPrice.Text != "")
            {
                n = dataGridView.Rows.Add();
                dataGridView.Rows[n].Cells[0].Value = txtProductName.Text;
                dataGridView.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                dataGridView.Rows[n].Cells[3].Value = txtTotalPrice.Text;

                total += int.Parse(txtTotalPrice.Text);
                TotalPriceLbl.Text = "P " + total;
            }
            else
            {
                MessageBox.Show("Minimun Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.RemoveAt(this.dataGridView.SelectedRows[0].Index);

            }
            catch { }
            total -= amount;
            TotalPriceLbl.Text = "P " + total;
        }



        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch { }

        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "CRAVING SATISFIER";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + TotalPriceLbl.Text;
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(dataGridView);

            total = 0;
            dataGridView.Rows.Clear();
            TotalPriceLbl.Text = "P " + total;
            MessageBox.Show("THANK YOU FOR YOUR PURCHASE!", "CravingSatisfier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
