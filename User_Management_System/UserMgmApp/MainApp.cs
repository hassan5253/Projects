using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserMgmApp
{
    public partial class MainApp : Form
    {
        private SqlConnection xConn;
        private DataTable xDataTable;
        public MainApp()
        {
            InitializeComponent();
            xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;");            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            xDataTable = new DataTable();
            SqlDataAdapter ABC = new SqlDataAdapter("Select * from tblUsers Where UName='"+txtUName.Text+"' and UPass='"+txtUPass.Text+"'",xConn);
            ABC.Fill(xDataTable);
            if (xDataTable.Rows.Count > 0)
            {
                groupBox1.Visible = false;
                mnuCustomer.Enabled = true;
                mnuProduct.Enabled = true;
                mnuStock.Enabled = true;
                mnuUsers.Enabled = true;
                //---------------------//
                mnuAddCustomer.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[3].ToString());
                mnuViewCustomer.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[4].ToString());
                mnuPrintCustomer.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[5].ToString());
                //--------------------//
                mnuAddProduct.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[6].ToString());
                mnuViewProduct.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[7].ToString());
                mnuPrintProduct.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[8].ToString());
                //-------------------//
                mnuAddItem.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[9].ToString());
                mnuViewItem.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[10].ToString());
                mnuPrintItem.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[11].ToString());
                //--------------------//
                mnuAddUser.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[12].ToString());
                mnuViewUser.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[13].ToString());
                mnuPrintUser.Visible = Convert.ToBoolean(xDataTable.Rows[0].ItemArray[14].ToString());
            }
            else
            {
                txtUName.Text = "Error in UName or UPass!";
                txtUPass.Text = "";
            }

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            mnuCustomer.Enabled = false;
            mnuProduct.Enabled = false;
            mnuStock.Enabled = false;
            mnuUsers.Enabled = false;
            txtUName.Clear();
            txtUPass.Clear();                
        }

        private void mnuAddUser_Click(object sender, EventArgs e)
        {
            new Form1().Show();            
        }
    }
}
