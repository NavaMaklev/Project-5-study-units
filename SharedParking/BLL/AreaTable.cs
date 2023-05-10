using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
  public  class AreaTable:GeneralTable
    {
        public AreaTable() : base("tblArea")
        {
            foreach (DataRow item in base.table.Rows)
            {
                list.Add(new Area(item));
            }
        }
        public List<Area> GetList()
        {
            return list.ConvertAll(x => (Area)x);
        }
    }
}
