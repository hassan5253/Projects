using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UserMgmApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;");
            SqlCommand xComm = new SqlCommand("Insert into tblUsers Values ('" + txtUName.Text + "','" + txtUPass.Text + "','" + chk1.Checked + "','" + chk2.Checked + "','" + chk3.Checked + "','" + chk7.Checked + "','" + chk8.Checked + "','" + chk9.Checked + "','" + chk4.Checked + "','" + chk5.Checked + "','" + chk6.Checked + "','" + chk10.Checked + "','" + chk11.Checked + "','" + chk12.Checked + "')", xConn);
            xConn.Open();
            xComm.ExecuteNonQuery();
            xComm.Dispose();
            xConn.Close();
            xConn.Dispose();
            txtUName.Text = "User Created...";
            txtUPass.Clear();
        }
    }
}
