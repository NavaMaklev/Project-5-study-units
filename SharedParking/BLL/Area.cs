using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class Area : GeneralRow
    {
        private int areaCode;
        private string areaName;
        public Area() { }
        public Area(DataRow row) :base(row){ }
        #region Properties
        public int AreaCode
        {
            get
            {
                return this.areaCode;
            }
            set
            {
                this.areaCode = value;
            }
        }
        public string AreaName
        {
            get
            {
                return this.areaName;
            }
            set
            {
                this.areaName = value;
            }
        }
        #endregion
        public override void FillDataRow()
        {
            row["areaCode"] = this.areaCode;
            row["areaName"] = this.areaName;
        }

        protected override void FillFields()
        {
            this.areaCode = Convert.ToInt32(row["areaCode"]);
            this.areaName = row["areaName"].ToString();
        }
        public override string ToString()
        {
            return areaName;
        }
    }
}
