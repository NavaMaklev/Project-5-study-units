using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class StaticOrdersTable:GeneralTable
    {
        public StaticOrdersTable() : base("tblStaticOrders")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new StaticOrder(item));
            }
        }
        public List<StaticOrder> GetList()
        {
            return list.ConvertAll(x => (StaticOrder)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.OrderCode) + 1;
        }
    }
}
