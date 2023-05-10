using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SharedParking.DAL;

namespace SharedParking.BLL
{
  public abstract  class GeneralTable
    {
        protected List<GeneralRow> list;
        protected DataTable table;
        private static Connect connect = new Connect();
        public GeneralTable(string nameTable)
        {
            table = connect.GetTable(nameTable);
            list = new List<GeneralRow>();
        }
       
         public void AddItem(GeneralRow item)
         {
             list.Add(item);

             item.row = table.NewRow();
             item.FillDataRow();
           this.  table.Rows.Add(item.row);

         }
        
        public void UpdateItem(GeneralRow item)
        {
            item.FillDataRow();
        }
        public void DeleteItem(GeneralRow item)
        {
            item.row.Delete();
            list.Remove(item);
        }
        public void SaveChanges()
        {
            connect.UpdateTable(table.TableName);
        }
    }
}
