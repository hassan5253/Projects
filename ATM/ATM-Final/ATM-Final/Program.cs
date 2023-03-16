using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM_Final
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 xForm = new Form1();
            xForm.ShowDialog();
        }
    }
}
