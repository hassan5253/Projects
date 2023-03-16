using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace AptechStudentMS
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }        
        private void GetStudent()
        {            
            DataTable xDataTable = new DataTable();
            SqlConnection xConn = new SqlConnection("Server=.; DataBase=Master; UID=sa; Password=123;");
            SqlDataAdapter xDAdapter = new SqlDataAdapter("Select * from tblStudent",xConn);
            xDAdapter.Fill(xDataTable);
            xDAdapter.Dispose();
            xConn.Dispose();            
            //-------------------------------//
            lstStudent.BeginUpdate();
            lstStudent.Columns.Clear();
            lstStudent.Items.Clear();
            foreach (DataColumn xCol in xDataTable.Columns)
            {  lstStudent.Columns.Add(xCol.ColumnName, 100);  }            
            for (int i = 0; i < xDataTable.Rows.Count; i++)
            {
                ListViewItem SID = new ListViewItem(xDataTable.Rows[i][0].ToString(),i); //SID
                SID.SubItems.Add(xDataTable.Rows[i][1].ToString()); //SName
                SID.SubItems.Add(xDataTable.Rows[i][2].ToString()); //Phone
                SID.SubItems.Add(xDataTable.Rows[i][3].ToString()); //Class
                lstStudent.Items.Add(SID);
            }
            lstStudent.EndUpdate();
        }
        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbView.Text.Equals("Large Icon"))
            { lstStudent.View = View.LargeIcon; }
            else if (cmbView.Text.Equals("Small Icon"))
            { lstStudent.View = View.SmallIcon; }
            else if (cmbView.Text.Equals("Tile"))
            { lstStudent.View = View.Tile; }
            else if (cmbView.Text.Equals("List"))
            { lstStudent.View = View.List; }
            if (cmbView.Text.Equals("Details"))
            { lstStudent.View = View.Details; }
            else { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {  GetStudent();    }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }
        private void lstStudent_DoubleClick(object sender, EventArgs e)
        {
            string SID = lstStudent.SelectedItems[0].SubItems[0].Text;
            string SName = lstStudent.SelectedItems[0].SubItems[1].Text;
            string Phone = lstStudent.SelectedItems[0].SubItems[2].Text;
            string Class = lstStudent.SelectedItems[0].SubItems[3].Text;
            MessageBox.Show("Details: ["+SID+"]---["+SName+"]---["+Phone+"]");
        }
    }
}
