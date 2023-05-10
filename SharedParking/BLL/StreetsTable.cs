using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class StreetsTable:GeneralTable
    {
        public StreetsTable() : base("tblStreets")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Street(item));
            }
        }
        public List<Street> GetList()
        {
            return list.ConvertAll(x => (Street)x);
        }
        public int GetNextKey()
        {
            if (list.Count == 0)
                return 1;
            return GetList().Max(x => x.StreetCode) + 1;
        }
        public List<Street> GetDisplayList()
        {
            return GetList().OrderBy(x => x.StreetName).ToList();
        }
    }
}
