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
    public partial class LoginScreen : Form
    {
        MainWindow xWindow;
        public LoginScreen()
        {
            InitializeComponent();
            xWindow = new MainWindow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
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

    }
}
