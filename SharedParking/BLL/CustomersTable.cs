using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class CustomersTable:GeneralTable
    {
        public CustomersTable() : base("tblCustomers")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Customer(item));
            }
        }
        public List<Customer> GetList()
        {
            return list.ConvertAll(x => (Customer)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x=>x.CustomerCode)+1;
        }
    }
}
