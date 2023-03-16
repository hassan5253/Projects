using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM_Final
{
    public partial class Changepin : Form
    {
        private string sAcc;
        private ConnectDB xDB;

        public Changepin(string abc)
        {
            InitializeComponent();
            sAcc = abc;
            xDB = new ConnectDB();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DataTable xDataTable = xDB.Selectcmd("Select PinNo from tblCustomer where AccountNo='" + sAcc + "'");
            if (xDataTable.Rows[0].ItemArray[0].ToString().Equals(txtOld.Text))
            {
                xDB.DMLcmd("Update tblCustomer set PinNo='" + txtNew.Text + "' Where AccountNo='" + sAcc + "'");
                xDB.CloseConn();
                this.Dispose();
            }
            else
            {
                txtOld.Text = "Error: Invalid PIN Number!";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            xDB.CloseConn();
            this.Dispose();
        }
    }
}
