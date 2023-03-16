using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperStoreApp
{
    public partial class ViewOrders : Form
    {
        private SqlConnection xConnection;
        public ViewOrders()
        {
            InitializeComponent();
            xConnection = new SqlConnection("Server=.; DataBase=SuperStore; UID=sa; Password=123;");
        }

        private void txtInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter xDataAdapter = new SqlDataAdapter("Select * from tblOrder Where InvoiceNo = '" + txtInvoice.Text + "'", xConnection);
                DataTable xDataTable = new DataTable();
                xDataAdapter.Fill(xDataTable);
                DGV1.DataSource = xDataTable;
                xDataAdapter.Dispose();
                DGV1.Columns[0].Width = 50;
                DGV1.Columns[1].Width = 50;
                DGV1.Columns[2].Width = 200;
                DGV1.Columns[3].Width = 50;
                DGV1.Columns[4].Width = 50;
                DGV1.Columns[5].Width = 50;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            xConnection.Dispose();
            Application.Exit();
        }
    }
}
