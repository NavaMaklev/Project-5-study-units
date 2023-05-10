using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class Street: GeneralRow
    {
        private int streetCode;
        private string streetName;
        private int areaCode;
        public Street() { }
        public Street(DataRow row) : base(row) { }
        public Area AreaHelp
        {
            get { return MyDB.areas.GetList().FirstOrDefault(x => x.AreaCode == this.areaCode); }
        }
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
        public int StreetCode
        {
            get
            {
                return this.streetCode;
            }
            set
            {
                this.streetCode = value;
            }
        }
        public string StreetName
        {
            get
            {
                return this.streetName;
            }
            set
            {
                this.streetName = value;
            }
        }

        #endregion
       public override void FillDataRow()
        {
            row["streetCode"] = this.streetCode;
            row["streetName"] = this.streetName;
            row["areaCode"] = this.areaCode;

        }
        protected override void FillFields()
        {
            this.streetCode = Convert.ToInt32(row["streetCode"]);
            this.streetName = row["streetName"].ToString();
            this.areaCode = Convert.ToInt32(row["areaCode"]);
        }
        public override string ToString()
        {
            return this.streetName;
        }
    }
}
