using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class OrderStatusTable:GeneralTable
    {
        public OrderStatusTable() : base("tblOrderStatus")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new OrderStatus(item));
            }
        }
        public List<OrderStatus> GetList()
        {
            return list.ConvertAll(x => (OrderStatus)x);
        }
    }
}
