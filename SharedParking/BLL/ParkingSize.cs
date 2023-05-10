using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingSize:GeneralRow
    {
        private int sizeCode;
        private string sizeName;
        public ParkingSize() { }
        public ParkingSize(DataRow row) : base(row) { }
        #region Properties
        public int SizeCode
        {
            get
            {
                return this.sizeCode;
            }
            set
            {
                this.sizeCode = value;
            }
        }
        public string SizeName
        {
            get
            {
                return this.sizeName;
            }
            set
            {
                this.sizeName = value;
            }
        }
       
        #endregion
       public override void FillDataRow()
        {
            row["sizeCode"] = this.sizeCode;
            row["sizeName"] = this.sizeName;
         
        }
        protected override void FillFields()
        {
            this.sizeCode = Convert.ToInt32(row["sizeCode"]);
            this.sizeName = row["sizeName"].ToString();
        }
        public override string ToString()
        {
            return sizeName;
        }
    }
}
