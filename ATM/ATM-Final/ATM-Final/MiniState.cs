using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ATM_Final
{
    public partial class MiniState : Form
    {
        private string sAcc;
        private ConnectDB xDB;
        private PrintDocument xDocument;
        public MiniState(string abc)
        {
            InitializeComponent();
            sAcc = abc;
        }

        private void MiniState_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            DGV1.DataSource = xDB.Selectcmd("Select * from tblTransactions where AccountNo='" + sAcc + "'");
            DGV1.Columns[0].Width = 50;
            DGV1.Columns[1].Width = 50;
            DGV1.Columns[2].Width = 50;
            DGV1.Columns[3].Width = 50;
            DGV1.Columns[4].Width = 50;
            int iMax = DGV1.Rows.Count;
            lblBalance.Text = "Current Balance: " + DGV1.Rows[iMax - 2].Cells[2].Value.ToString() + " Rs.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            xDB.CloseConn();
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             xDocument = new PrintDocument();
             xDocument.PrintPage += new PrintPageEventHandler(xDocument_PrintPage);
             PrintPreviewDialog PPD = new PrintPreviewDialog();
             PPD.Document = xDocument;
             PPD.Show();
        }
        private void xDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font F = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
            Brush B = Brushes.Black;
            e.Graphics.DrawImage(Image.FromFile("BankLogo.jpg"), 02, 2);
            int yAxis = 300;
            for (int i = 0; i < DGV1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(DGV1.Rows[i].Cells[0].Value.ToString(), F, B, 10, yAxis); //AID
                e.Graphics.DrawString(DGV1.Rows[i].Cells[1].Value.ToString(), F, B, 50, yAxis); //Account
                e.Graphics.DrawString(DGV1.Rows[i].Cells[2].Value.ToString(), F, B, 90, yAxis); //Ballance
                e.Graphics.DrawString(DGV1.Rows[i].Cells[3].Value.ToString(), F, B, 200, yAxis); //Deposit
                e.Graphics.DrawString(DGV1.Rows[i].Cells[4].Value.ToString(), F, B, 300, yAxis); //Withdraw
                e.Graphics.DrawString(DGV1.Rows[i].Cells[5].Value.ToString(), F, B, 400, yAxis); //Remarks
                e.Graphics.DrawString(DGV1.Rows[i].Cells[6].Value.ToString(), F, B, 600, yAxis); //Date_time
                yAxis = yAxis + 20;
            }

        }
    }
}
