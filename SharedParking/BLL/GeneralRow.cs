using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SharedParking.BLL
{
   public abstract class GeneralRow
    {
        public DataRow row;
        public GeneralRow() { }
        public GeneralRow(DataRow row)
        {
            this.row = row;
            FillFields();
        }
        protected abstract void FillFields();
        public abstract void FillDataRow();
    }
}
