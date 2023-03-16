using System;
using System.Transactions;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TransactionApp
{ public partial class Form1 : Form
    {   public Form1()
        {     InitializeComponent();   }
        private void btnExit_Click(object sender, EventArgs e)
        {      Application.Exit();   }
        private void btnSave_Click(object sender, EventArgs e)
        {            
            using (TransactionScope ABC = new TransactionScope(TransactionScopeOption.RequiresNew))
            {   using (SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;"))
                {
                    SqlCommand xCommand = new SqlCommand("Insert into tblStudent values ('Sana Taak','03001234567','ADSE-1')",xConn);
                    xConn.Open();
                    xCommand.ExecuteNonQuery();
                }                
                using (SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;"))
                {
                    SqlCommand xCommand = new SqlCommand("Insert into tblStudent values ('Bilal','03001234567','ADSE-1')", xConn);
                    xConn.Open();
                    xCommand.ExecuteNonQuery();
                }                
                using (SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;"))
                {
                    SqlCommand xCommand = new SqlCommand("Update tblStudent set Class='ASP Net' Where SID=103", xConn);
                    xConn.Open();
                    xCommand.ExecuteNonQuery();
                }                
                using (SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;"))
                {
                    SqlCommand xCommand = new SqlCommand("Update tblStudent set Class='Oracle' Where SID=101", xConn);
                    xConn.Open();
                    xCommand.ExecuteNonQuery();
                }                
                using (SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;"))
                {
                    SqlCommand xCommand = new SqlCommand("Delete from tblStudent Where SID=200", xConn);
                    xConn.Open();
                    xCommand.ExecuteNonQuery();
                }                
                ABC.Complete();
                ABC.Dispose();
            }
            MessageBox.Show("Transaction Complete Successfully");            
        }
    }
}
