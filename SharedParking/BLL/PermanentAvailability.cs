using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class PermanentAvailability:GeneralRow
    {
        private int code;
        private int parkingCode;
        private string dayInWeek;
        private DateTime fromAnHour;
        private DateTime toAnHour;
        public PermanentAvailability() { }
        public PermanentAvailability(DataRow row) : base(row) { }
        #region Properties
        public int Code
        {
            get
            {
                return this.code;
            }
            set
            {
                this.code = value;
            }
        }
        public int ParkingCode
        {
            get
            {
                return this.parkingCode;
            }
            set
            {
                this.parkingCode = value;
            }
        }
        public string DayInWeek
        {
            get
            {
                return this.dayInWeek;
            }
            set
            {
                this.dayInWeek = value;
            }
        }
        public DateTime FromAnHour
        {
            get
            {
                return this.fromAnHour;
            }
            set
            {
                this.fromAnHour = value;
            }
        }
        public DateTime ToAnHour
        {
            get
            {
                return this.toAnHour;
            }
            set
            {
                this.toAnHour = value;
            }
        }
      
     
        #endregion
        public override void FillDataRow()
        {
            row["code"] = this.code;
            row["parkingCode"] = this.parkingCode;
            row["dayInWeek"] = this.dayInWeek;
            row["fromAnHour"] = this.fromAnHour;
            row["toAnHour"] = this.toAnHour;
        }
        protected override void FillFields()
        {
            this.code = Convert.ToInt32(row["code"]);
            this.dayInWeek = row["dayInWeek"].ToString();
            this.fromAnHour = Convert .ToDateTime (row["fromAnHour"]);
            this.toAnHour = Convert.ToDateTime(row["toAnHour"]);
            this.parkingCode = Convert.ToInt32(row["parkingCode"]);
        }
    }
}
