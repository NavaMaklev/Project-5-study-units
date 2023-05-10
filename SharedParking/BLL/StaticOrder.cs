using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class StaticOrder: GeneralRow
    {
        private int orderCode;
        private int customerCode;
        private DateTime orderDate;
        private string dayInWeek;
        private DateTime fromAnHour;
        private DateTime toAnHour;
        private int parkingCode;
        private DateTime endDate;
        private int pricePerMonth;
        private int status;
        public StaticOrder() { }
        public StaticOrder(DataRow row) : base(row) { }
        public Customer CustomerHelp
        {
            get { return MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == this.customerCode); }
        }
        #region Properties
        public int CustomerCode
        {
            get
            {
                return this.customerCode;
            }
            set
            {
                this.customerCode = value;
            }
        }
        public int OrderCode
        {
            get
            {
                return this.orderCode;
            }
            set
            {
                this.orderCode = value;
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
        public int PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = value;
            }
        }
        public int Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                this.orderDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return this.endDate;
            }
            set
            {
                this.endDate = value;
            }
        }
        #endregion
        public override void FillDataRow()
        {
            row["customerCode"] = this.customerCode;
            row["orderCode"] = this.orderCode;
            row["orderDate"] = this.orderDate;
            row["dayInWeek"] = this.dayInWeek;
            row["fromAnHour"] = this.fromAnHour;
            row["toAnHour"] = this.toAnHour;
            row["parkingCode"] = this.parkingCode;
            row["endDate"] = this.endDate;
            row["pricePerMonth"] = this.pricePerMonth;
            row["status"] = this.status;
        }
        protected override void FillFields()
        {
            this.customerCode = Convert.ToInt32(row["customerCode"]);
            this.dayInWeek = row["dayInWeek"].ToString();
            this.fromAnHour = Convert.ToDateTime(row["fromAnHour"]);
            this.toAnHour = Convert.ToDateTime(row["toAnHour"]);
            this.orderDate = Convert.ToDateTime(row["orderDate"]);
            this.endDate = Convert.ToDateTime(row["endDate"]);
            this.orderCode = Convert.ToInt32(row["orderCode"]);
            this.status = Convert.ToInt32(row["status"]);
            this.pricePerMonth = Convert.ToInt32(row["pricePerMonth"]);
            this.parkingCode = Convert.ToInt32(row["parkingCode"]);
        }
    }
}
