using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CheckBoxApp
{
    public partial class Form1 : Form
    {
        private SqlConnection xConn;
        public Form1()
        {
            InitializeComponent();
            xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; PWD=123");

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            string xQuery = "Select ";
            foreach (object A in chkColumns.CheckedItems)
            {
                xQuery += A+",";
            }
            xQuery = xQuery.Remove(xQuery.Length - 1);
            xQuery += " from tblEMP";
            DataTable xTable = new DataTable();
            new SqlDataAdapter(xQuery, xConn).Fill(xTable);
            DGV1.DataSource = xTable;
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
