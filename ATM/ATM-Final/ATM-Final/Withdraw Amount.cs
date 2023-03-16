using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace ATM_Final
{
    public partial class Withdraw_Amount : Form
    {
        private string sAcc;
        private int iBalance;
        private ConnectDB xDB;

        public Withdraw_Amount(string abc)
        {
            InitializeComponent();
            sAcc = abc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Withdraw_Amount_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            DataTable xDataTable = xDB.Selectcmd("Select Balance from tblTransactions Where AccountNo = '" + sAcc + "'");
            int iMax = xDataTable.Rows.Count - 1;
            iBalance = Int32.Parse(xDataTable.Rows[iMax].ItemArray[0].ToString());
            lblBalance.Text = "Current Balance: " + iBalance + " Rs.";
        }

        private void btnWithdraw_Click(object sender, System.EventArgs e)
        {
                int iAmount = 0;
            if (rdo1000.Checked)
            {   iAmount = 1000; }

            if (rdo10K.Checked)
            {
                iAmount = 10000;
            }
            if (rdo2000.Checked)
            {
                iAmount = 2000;
            }
            if (rdo3000.Checked)
            {
                iAmount = 3000;
            }
            if (rdo500.Checked)
            {
                iAmount = 500;
            }
            if(rdo5000.Checked)
            {
                iAmount = 5000;
            }
            //------------------------------------//
            if (iAmount > iBalance)
            {
                lblError.Visible = true;
                lblError.Text = "Error: Invalid Amount! Select another option.";
            }
            else
            {
                iBalance = iBalance - iAmount;
                xDB.DMLcmd("Insert into tblTransactions values('" + sAcc + "'," + iBalance + ",0," + iAmount + ",'WithDraw Amount','" + DateTime.Now + "')");
                this.Dispose();
            }
        }
    }
}
