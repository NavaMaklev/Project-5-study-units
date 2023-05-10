using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class PaymentsTable:GeneralTable
    {
        public PaymentsTable() : base("tblPayments")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Payment(item));
            }
        }
        public List<Payment> GetList()
        {
            return list.ConvertAll(x => (Payment)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.PaymentCode) + 1;
        }
    }
}
