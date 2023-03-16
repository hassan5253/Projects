using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Final
{
    
    public partial class NewAccount : Form
    {
        private ConnectDB xDB;
        private int iAcc;
        public NewAccount()
        {
            InitializeComponent();
        }
        private void NewAccount_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtPin.Text.Length != 4)
            {
                txtPin.Text = "Error: Must be 4 digits!";
            }
            else
            {
                timer1.Start();
                xDB.DMLcmd("Insert into tblCustomer values ('" + txtPin.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtNIC.Text + "','" + txtAdres.Text + "','" + DateTime.Now.ToString("dd-MMM-yyyy") + "')");
                MessageBox.Show("Account Open Successfully\nNote: For Activation\nEnter Opening Balance.", ":: Open Account ::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdres.Clear();
                txtName.Clear();
                txtNIC.Clear();
                txtPhone.Clear();
                txtPin.Clear();
                FillGrid();
            }
        }

        private void FillGrid()
        {
            DGV1.DataSource = xDB.Selectcmd("Select AccountNo, PinNo, FullName, PhoneNo, N_I_C from tblCustomer where Date_Time='" + DateTime.Now.ToString("dd-MMM-yyyy") + "'");
            DGV1.Columns[0].Width = 50;
            DGV1.Columns[1].Width = 50;
            DGV1.Columns[1].Width = 100;
            DGV1.Columns[1].Width = 70;
            DGV1.Columns[1].Width = 80;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            iAcc = (int)DGV1.CurrentRow.Cells[0].Value;
            txtBalance.Enabled = true;
            btnOK.Enabled = true;
            lblAcc.Text = "Enter Opening Balance for " + iAcc + ": "; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            xDB.DMLcmd("Insert into tblTransactions values ('" + iAcc + "'," + Int32.Parse(txtBalance.Text) + "," + Int32.Parse(txtBalance.Text) + ",0,'Deposit Amount','" + DateTime.Now.ToString() + "')");
            txtBalance.Clear();
            txtBalance.Enabled = false;
            btnOK.Enabled = false;
            lblAcc.Text = "Enter Opening Balance";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value++;
            }
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        } 
    }
}
