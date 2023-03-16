using System;
using System.Data;
using System.Data.SqlClient;

namespace ATM_Final
{
    class ConnectDB
    {
        private SqlCommand xCommand;
        private SqlConnection xConnection;
        private SqlDataAdapter xDataAdapter;

        public ConnectDB()
        {
            xConnection = new SqlConnection("Data Source=.; Initial Catalog=ATMDB; UID=sa; Password=123");
        }
        public void DMLcmd(string sCMD)
        {
            xConnection.Open();
            xCommand = new SqlCommand(sCMD, xConnection);
            xCommand.ExecuteNonQuery();
            xCommand.Dispose();
            xConnection.Close();
        }
        public DataTable Selectcmd(string sSelect)
        {
            DataTable xDataTable = new DataTable();
            xDataAdapter = new SqlDataAdapter(sSelect, xConnection);
            xDataAdapter.Fill(xDataTable);
            xDataAdapter.Dispose();
            return (xDataTable);
        }
        public void CloseConn()
        {
            xConnection.Dispose();
        }

    }
}
