using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingOwnersTable:GeneralTable
    {
        public ParkingOwnersTable() : base("tblParkingOwners")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new ParkingOwner(item));
            }
        }
        public List<ParkingOwner> GetList()
        {
            return list.ConvertAll(x => (ParkingOwner)x);
        }
    }
}
