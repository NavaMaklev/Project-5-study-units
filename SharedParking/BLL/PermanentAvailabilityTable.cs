using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class PermanentAvailabilityTable:GeneralTable
    {
        public PermanentAvailabilityTable() : base("tblPermanentAvailability")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new PermanentAvailability(item));
            }
        }
        public List<PermanentAvailability> GetList()
        {
            return list.ConvertAll(x => (PermanentAvailability)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.Code) + 1;
        }
    }
}
