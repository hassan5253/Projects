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
    public partial class Form1 : Form
    {
        LoginScreens xLogin;
        public Form1()
        {
            InitializeComponent();
            xWaitingBar.Maximum = 100; // Set Maximum Value to 100%
            xLogin = new LoginScreens();
        }

        private void xTimer_Tick(object sender, EventArgs e)
        {
            if (xWaitingBar.Value < xWaitingBar.Maximum)
            {
                xWaitingBar.Value++;
            }
            else if (xWaitingBar.Value == xWaitingBar.Maximum)
            {
                this.Dispose();
                xLogin.ShowDialog();
            }
            
        }

        



    }
}
