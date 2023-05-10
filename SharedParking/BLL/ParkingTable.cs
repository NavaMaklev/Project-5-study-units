using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingTable:GeneralTable
    {
        public ParkingTable() : base("tblParking")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Parking(item));
            }
        }
        public List<Parking> GetList()
        {
            return list.ConvertAll(x => (Parking)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.ParkingCode) + 1;
        }
    }
}
