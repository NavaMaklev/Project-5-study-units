using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingAvailabilityTable:GeneralTable
    {
        public ParkingAvailabilityTable() : base("tblParkingAvailability")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ParkingAvailability(item));
            }
        }
        public List<ParkingAvailability> GetList()
        {
            return list.ConvertAll(x => (ParkingAvailability)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.AvailabilityCode) + 1;
        }
    }
}
