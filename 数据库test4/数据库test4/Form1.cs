using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据库test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void dataGrid2_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.oleDbDataAdapter1.Fill(this.dataSet11);
            this.oleDbDataAdapter2.Fill(this.dataSet11);
        }

        private void dataGrid2_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*int nOrderID
                = Int32.Parse(this.dataGrid1[this.dataGrid1.CurrentRowIndex, 0].ToString());*/
            int row = dataGrid1.CurrentRowIndex;
            int nOrderID
                = Int32.Parse(this.dataGrid1[row, 0].ToString());
            String strSalesSelect = "select * from Sales.SalesOrderDetail where SalesOrderID=?";
            OleDbCommand cmdSalesSelect = new OleDbCommand(strSalesSelect);
            cmdSalesSelect.Connection = this.oleDbConnection1;
            cmdSalesSelect.Parameters.Add("@p1", OleDbType.Integer, 5).Value = nOrderID;
            OleDbDataAdapter ad = new OleDbDataAdapter(cmdSalesSelect);
            DataSet ds = new DataSet();
            ad.Fill(ds, "curOrder");
            dataGrid2.DataSource = ds.Tables["curOrder"];
        }
    }
}
