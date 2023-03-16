using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Data;
using System.Windows.Forms;


namespace ATM_Final
{
    public partial class ATM_Client_App : Form
    {
        private ConnectDB xDB;
        private string sAcc;
        public ATM_Client_App(string abc)
        {
            InitializeComponent();
            sAcc = abc; 
        }

        private void ATM_Client_App_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            DataTable xDataTable = xDB.Selectcmd("Select FullName from tblCustomer where AccountNo='" + sAcc+ "'");
            label1.Text = "Welcome : " + xDataTable.Rows[0].ItemArray[0].ToString() + ".";
           
        }

        //private void btnWithDraw_Click(object sender, System.EventArgs e)
        //{
        //    Withdraw_Amount WD = new Withdraw_Amount(sAcc);
        //    WD.ShowDialog();
        //}
        private void btnWithDraw_Click_1(object sender, System.EventArgs e)
        {
            Withdraw_Amount WD = new Withdraw_Amount(sAcc);
            WD.ShowDialog();
        }

        private void btnDeposit_Click_1(object sender, System.EventArgs e)
        {
            Deposit DP = new Deposit(sAcc);
            DP.ShowDialog();
        }

        private void btnBalance_Click_1(object sender, System.EventArgs e)
        {
            MiniState MS = new MiniState(sAcc);
            MS.ShowDialog();
        }

        private void btnChangePin_Click_1(object sender, System.EventArgs e)
        {
            Changepin CPin = new Changepin(sAcc);
            CPin.ShowDialog();
        }

        private void btnLogout_Click(object sender, System.EventArgs e)
        {
            LoginScreens LoginScreen = new LoginScreens();
            this.Dispose();
            LoginScreen.ShowDialog();
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

       

        //internal void ShowDialog(string sAcc)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
