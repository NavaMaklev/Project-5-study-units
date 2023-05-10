using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingAvailability: GeneralRow
    {
        private int availabilityCode;
        private int parkingCode;
        private DateTime fromDate;
        private DateTime toDate;
        private DateTime fromAnHour;
        private DateTime toAnHour;
        public ParkingAvailability() { }
        public ParkingAvailability(DataRow row) : base(row) { }
        #region Properties
        public int AvailabilityCode
        {
            get
            {
                return this.availabilityCode;
            }
            set
            {
                this.availabilityCode = value;
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
        public DateTime FromDate
        {
            get
            {
                return this.fromDate;
            }
            set
            {
                this.fromDate = value;
            }
        }
        public DateTime ToDate
        {
            get
            {
                return this.toDate;
            }
            set
            {
                this.toDate = value;
            }
        }
  
        #endregion
        public override void FillDataRow()
        {
            row["availabilityCode"] = this.availabilityCode;
            row["parkingCode"] = this.parkingCode;
            row["fromDate"] = this.fromDate.Date;
            row["toDate"] = this.toDate.Date;
            row["fromAnHour"] = this.fromAnHour;
            row["toAnHour"] = this.toAnHour;
        }
        protected override void FillFields()
        {
            this.availabilityCode = Convert.ToInt32(row["availabilityCode"]);
            this.fromAnHour = Convert.ToDateTime(row["fromAnHour"]);
            this.toAnHour = Convert.ToDateTime(row["toAnHour"]);
            this.fromDate = Convert.ToDateTime(row["fromDate"]);
            this.toDate = Convert.ToDateTime(row["toDate"]);
            this.parkingCode = Convert.ToInt32(row["parkingCode"]);
        }
    }
}
