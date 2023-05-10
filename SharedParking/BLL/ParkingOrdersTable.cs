using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingOrdersTable:GeneralTable
    {
        public ParkingOrdersTable() : base("tblParkingOrders")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ParkingOrder(item));
            }
        }
        public List<ParkingOrder> GetList()
        {
            return list.ConvertAll(x => (ParkingOrder)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.OrderCode) + 1;
        }
    }
}
