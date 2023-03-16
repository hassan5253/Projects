using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperStoreApp
{
    public partial class Form1 : Form
    {
        private SqlConnection xConnection;
        private SqlCommand xCommand;
        public Form1()
        {
            InitializeComponent();
            DGV1.Columns.Add("Product", "Product");
            DGV1.Columns.Add("UPrice", "UPrice");
            DGV1.Columns.Add("Qty", "Qty");
            DGV1.Columns.Add("Total", "Total");
            DGV1.Columns[0].Width = 200;
            DGV1.Columns[1].Width = 50;
            DGV1.Columns[2].Width = 50;
            DGV1.Columns[3].Width = 50;
            xConnection = new SqlConnection("Server=.; DataBase=aptech; UID=sa; Password=123;");
            //--------------------------------------//
            SqlDataAdapter xDataAdapter = new SqlDataAdapter("Select PName from tblProduct",xConnection);
            DataTable xDataTable = new DataTable();
            xDataAdapter.Fill(xDataTable);
            xDataAdapter.Dispose();
            //--------------------------------------//
            AutoCompleteStringCollection ABC = new AutoCompleteStringCollection();
            for (int i = 0; i < xDataTable.Rows.Count; i++)
            {
                ABC.Add(xDataTable.Rows[i][0].ToString());
            }
            //------------------------------------//
            txtProduct.AutoCompleteCustomSource = ABC;
            txtProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //----------------------------------//
        }      

        private void btnExit_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DGV1.Rows.Count > 1)
            {
                xConnection.Open();
                xCommand = new SqlCommand("SaveCustomer", xConnection);
                xCommand.CommandType = CommandType.StoredProcedure;
                xCommand.Parameters.AddWithValue("@A", txtName.Text);
                xCommand.Parameters.AddWithValue("@B", txtPhone.Text);
                int iInvoice = Convert.ToInt32(xCommand.ExecuteScalar());
                xCommand.Dispose();
                //MessageBox.Show("Invoice Number: " + iInvoice);
                //------------------------------------------//
                xCommand = new SqlCommand();
                xCommand.Connection = xConnection;
                string A, B, C, D;
                for (int i = 0; i < DGV1.Rows.Count - 1; i++)
                {
                    A = DGV1.Rows[i].Cells[0].Value.ToString(); //PName
                    B = DGV1.Rows[i].Cells[1].Value.ToString(); //UPrice
                    C = DGV1.Rows[i].Cells[2].Value.ToString(); //Quantity
                    D = DGV1.Rows[i].Cells[3].Value.ToString(); //Total
                    xCommand.CommandText = "Insert into tblOrder values ('"+iInvoice+"','"+A+"','"+B+"','"+C+"','"+D+"')";
                    xCommand.ExecuteNonQuery();
                }
                xCommand.Dispose();
                xConnection.Close();
                DGV1.Rows.Clear();
            }
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { txtQty.Focus(); }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter xDataAdapter = new SqlDataAdapter("Select * from tblProduct Where PName='" + txtProduct.Text + "'", xConnection);
                DataTable xDataTable = new DataTable();
                xDataAdapter.Fill(xDataTable);
                xDataAdapter.Dispose();
                string A, B, C;
                A = xDataTable.Rows[0][1].ToString(); //PName
                B = xDataTable.Rows[0][2].ToString(); //UPrice
                C = txtQty.Text;
                int iTotal = Int16.Parse(C) * Int16.Parse(B);
                DGV1.Rows.Add(A, B, C, iTotal);
            }            
        }
    }
}
