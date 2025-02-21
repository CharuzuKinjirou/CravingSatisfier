using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;


namespace Craving_Satisfier
{
    public partial class TableScheduler : UserControl
    {
        SqlConnection cn = new SqlConnection(@"data source = DESKTOP-9VINEHP;database = CravingSatisfier; integrated security = True");
        Function fn = new Function();
        static String startdate;
        static String enddate;
        String query;
        public TableScheduler()
        {
            InitializeComponent();
            monthCalendar1.SelectionStart = DateTime.Now.Date;
        }

        private void CheckAvailbutton_Click(object sender, EventArgs e)
        {
            startdate = monthCalendar1.SelectionStart.Month + "/" + monthCalendar1.SelectionStart.Day + "/" + monthCalendar1.SelectionStart.Year + " " + StartTimedropdown.Text;

            enddate = monthCalendar1.SelectionStart.Month + "/" + monthCalendar1.SelectionStart.Day + "/" + monthCalendar1.SelectionStart.Year + " " + EndTimedropdown.Text;
            findAvailableTable();
            TableNoComboBox.Visible = true;
        }

        private void findAvailableTable()
        {
            String mycon = "data source = DESKTOP-9VINEHP;database = CravingSatisfier; integrated security = True";
            String myquery = "select DISTINCT tablenum from TableScheduler where ((dtstart between '" + startdate + "' and '" + enddate + "' ) or (dtend between '" + startdate + "' and '" + enddate + "' ))";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Tables given below.");
            }
            cn.Close();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
           
            if(txtTotalPerson != null)
            {
                string tableno = this.TableNoComboBox.Text;
                String updatepass = "insert into TableScheduler (tablenum,customername,mobilenumber,totalperson,dtstart,dtend) values ('" + tableno + "','" + txtClientName.Text + "'," + txtClientNumber.Text + ", " + txtTotalPerson.Text + ", " + StartTimedropdown.Text + ", " + EndTimedropdown.Text + ")";
                cn.Open();
                MessageBox.Show("successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
            }

        

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.Visible = true;
        }
    }
}
