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
    public partial class MainWindow : Form
    {
        private ConnectDB xDB;
        DataTable xTable;
        public MainWindow()
        {
            InitializeComponent();
            xDB = new ConnectDB();
            xTable = new DataTable();
            SelectAcc();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            LoginScreens LoginScreen = new LoginScreens();
            this.Dispose();
            LoginScreen.ShowDialog();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount NACC = new NewAccount();
            NACC.ShowDialog();
        }

        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAccount ViewAcc = new ViewAccount();
            ViewAcc.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositRPT Deposit = new DepositRPT();
            Deposit.ShowDialog();
        }

        private void withDrawReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawRPT WithDraw = new WithdrawRPT();
            WithDraw.ShowDialog();
        }

        private void balanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceRPT Balance = new BalanceRPT();
            Balance.ShowDialog();
        }

        //private void SelectAcc()
        //{

        //    xAccList.Items.Clear();
        //    xTable = xDB.Selectcmd("Select FullName from tblCustomer where Date_Time   = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
        //    if (xTable.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < xTable.Rows.Count; i++)
        //        {
        //            xAccList.Items.Add(xTable.Rows[i][0].ToString());
        //        }
        //    }
        //    else
        //    {

        //        xAccList.Items.Add("No data found for today.");
        //    }
        //}




        private void SelectAcc() 
        { 
        xAccList.Items.Clear();
        xTable = xDB.Selectcmd("Select FullName from tblCustomer where Date_Time   = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            //xTable = xDB.Selectcmd("Select AccountNo ,Deposit,Remarks from tblTransactions where Date_Time =  '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (xTable.Rows.Count > 0)
            {

                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    xAccList.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {

                xAccList.Items.Add("No data found for today.");
            }
        
        }


        private void xTimer_Tick(object sender, EventArgs e)
        {
            SelectAcc(); 
            SelectTrac();
            TotalCutomer();
            AccNum();
            Depst();
            Withdraw();
            AccDate();
        }

        private void SelectTrac()
        {

            Trclist.Items.Clear();
            xTable = xDB.Selectcmd("Select Remarks from tblTransactions where Date_Time = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            //xTable = xDB.Selectcmd("Select AccountNo ,Deposit,Remarks from tblTransactions where Date_Time =  '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (xTable.Rows.Count > 0)
            {

                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    Trclist.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {

                Trclist.Items.Add("No data found for today.");
            }

        }

        private void TotalCutomer()
        {
            Totalcustmerlst.Items.Clear();
            xTable = xDB.Selectcmd("Select FullName from tblCustomer");
            if (xTable.Rows.Count > 0)
            {
                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    Totalcustmerlst.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {
                Totalcustmerlst.Items.Add("No data found for today.");
            }
        }
        private void AccNum()
        {
            lstAccno.Items.Clear();
            xTable = xDB.Selectcmd("Select AccountNo from tblTransactions where Date_Time = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (xTable.Rows.Count > 0)
            {
                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    lstAccno.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {
                lstAccno.Items.Add("No data found for today.");
            }
        }
        private void Depst()
        {
            lstDpst.Items.Clear();
            xTable = xDB.Selectcmd("Select Deposit from tblTransactions where Date_Time = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (xTable.Rows.Count > 0)
            {
                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    lstDpst.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {
                lstDpst.Items.Add("No data found for today.");
            }
        }
        private void Withdraw()
        {
            lstwithDraw.Items.Clear();
            xTable = xDB.Selectcmd("Select WithDraw  from tblTransactions where Date_Time = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'"); if (xTable.Rows.Count > 0)
            {
                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    lstwithDraw.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {
                lstwithDraw.Items.Add("No data found for today.");
            }
        }
        private void AccDate()
        {
            lstDate.Items.Clear();
            xTable = xDB.Selectcmd("Select Date_Time  from tblTransactions where Date_Time = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'");
            if (xTable.Rows.Count > 0)
            {
                for (int i = 0; i < xTable.Rows.Count; i++)
                {
                    lstDate.Items.Add(xTable.Rows[i][0].ToString());
                }
            }
            else
            {
                lstDate.Items.Add("No data found for today.");
            }
        }
    }
}
