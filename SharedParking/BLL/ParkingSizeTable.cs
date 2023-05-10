using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
     public class ParkingSizeTable:GeneralTable
    {
        public ParkingSizeTable() : base("tblParkingSize")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ParkingSize(item));
            }
        }
        public List<ParkingSize> GetList()
        {
            return list.ConvertAll(x => (ParkingSize)x);
        }
    }
}
