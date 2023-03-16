using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ATM_Final
{
    public partial class DepositRPT : Form
    {
        private ConnectDB xDB;
        private PrintDocument xDocument;
        public DepositRPT()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                DGV1.DataSource = xDB.Selectcmd("Select * from tblTransactions where AccountNo = '" + txtSearch.Text + "' and Remarks='Deposit Amount'");
                DGV1.Columns[0].Width = 50;
                DGV1.Columns[1].Width = 50;
            }
            catch (Exception)
            { txtSearch.Text = "Error: Ivalid Account No."; }      
        }

        private void DepositRPT_Load(object sender, EventArgs e)
        {
            xDB = new ConnectDB();
            btnShow_Click(null, null);
        }    
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            DGV1.DataSource = xDB.Selectcmd("Select * from tblTransactions Where Remarks='Deposit Amount'");
            DGV1.Columns[0].Width = 50;
            DGV1.Columns[1].Width = 50;
            DGV1.Columns[2].Width = 70;
            DGV1.Columns[3].Width = 70;
            DGV1.Columns[4].Width = 70;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            e.Graphics.DrawImage(Image.FromFile("BankLogo.jpg"), 2, 2);
            int yAxis = 300;
            for (int i = 0; i < DGV1.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(DGV1.Rows[i].Cells[0].Value.ToString(), F, B, 10, yAxis); //Account Number
                e.Graphics.DrawString(DGV1.Rows[i].Cells[1].Value.ToString(), F, B, 50, yAxis); //Pin Number
                e.Graphics.DrawString(DGV1.Rows[i].Cells[2].Value.ToString(), F, B, 90, yAxis); //Full name
                e.Graphics.DrawString(DGV1.Rows[i].Cells[3].Value.ToString(), F, B, 200, yAxis); //Phone Number
                e.Graphics.DrawString(DGV1.Rows[i].Cells[4].Value.ToString(), F, B, 300, yAxis); //NIC Number
                e.Graphics.DrawString(DGV1.Rows[i].Cells[5].Value.ToString(), F, B, 400, yAxis); //Address Number
                e.Graphics.DrawString(DGV1.Rows[i].Cells[6].Value.ToString(), F, B, 600, yAxis); //Date
                yAxis = yAxis + 20;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value++;
            }
        }                      
    }
}
