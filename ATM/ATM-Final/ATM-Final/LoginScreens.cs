using System;
using System.Data;
using System.Windows.Forms;

namespace ATM_Final
{
    public partial class LoginScreens : Form
    {
        private ConnectDB xDB;
        private string sAcc;

        MainWindow xWindow;
        public LoginScreens()
        {
            InitializeComponent();
            xWindow = new MainWindow();
        }

        private void LoginScreens_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            Adminlgn.Visible = false;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            DataTable xDataTable = xDB.Selectcmd("Select PinNo, FullName from tblCustomer where AccountNo='" + txtAcc.Text + "'");
            if (xDataTable.Rows.Count > 0)
            {
                if (xDataTable.Rows[0].ItemArray[0].ToString().Equals(txtPin.Text))
                {
                    sAcc = txtAcc.Text;
                    txtAcc.Clear();
                    txtPin.Clear();
                    ATM_Client_App clientApp = new ATM_Client_App(sAcc);
                    this.Dispose();
                    clientApp.ShowDialog();
                    //lblFullName.Text = "Welcome to: " + xDataTable.Rows[0].ItemArray[1].ToString() + ".";
                }
                else
                {
                    txtAcc.Text = "Error: Invalid Pin Number!";
                }
            }
            else
            {
                txtAcc.Text = "Error: Invalid Account Number!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdminUName.Text.Equals("admin") && txtAdminUpass.Text.Equals("1234"))
            {
                this.Dispose();
                xWindow.ShowDialog();

            }
            else if (txtAdminUName.Text.Equals("User1") && txtAdminUpass.Text.Equals("abcd"))
            {
                this.Dispose();
                xWindow.ShowDialog();

            }
            else
            {
                txtAdminUName.Text = "Error: Wrong UserName or Password!";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlgn.Visible = false;
            UserLogn.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Adminlgn.Visible = true;
            UserLogn.Visible = false;
        }

        private void UserLogn_Enter(object sender, EventArgs e)
        {

        }
  
    }
}
