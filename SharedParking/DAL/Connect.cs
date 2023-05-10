using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SharedParking.DAL
{
    class Connect
    {
        private DataSet dataSet;
        private OleDbConnection con;
        private OleDbDataAdapter adapter;
        public Connect()
        {
            dataSet = new DataSet();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + System.Windows.Forms.Application.StartupPath + "\\SharedParking.accdb'");
        }
        private void AddTable(string tableName)
        {
            adapter = new OleDbDataAdapter("select * from " + tableName, con);
            adapter.Fill(dataSet, tableName);
        }
        public DataTable GetTable(string tableName)
        {
            if (!(dataSet.Tables.Contains(tableName)))
            {
                AddTable(tableName);
            }
            return dataSet.Tables[tableName];
        }
        public void UpdateTable(string tableName)
        {
            adapter = new OleDbDataAdapter("select * from " + tableName, con);
            OleDbCommandBuilder oleDbCommandBuilder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = oleDbCommandBuilder.GetInsertCommand();
            adapter.DeleteCommand = oleDbCommandBuilder.GetDeleteCommand();
            adapter.UpdateCommand = oleDbCommandBuilder.GetUpdateCommand();
            adapter.Update(dataSet,tableName);
        }
    }
}
