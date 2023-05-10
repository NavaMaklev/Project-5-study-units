using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingOrder:GeneralRow
    {
        private int orderCode;
        private int customerCode;
        private DateTime orderDate;
        private int parkingCode;
        private DateTime fromAnHour;
        private DateTime toAnHour;
        private int status;
        private int finalPrice;
        public ParkingOrder() { }
        public ParkingOrder(DataRow row) : base(row) { }
        public Customer CustomerHelp
        {
            get {return MyDB.customers.GetList().FirstOrDefault(x=>x.CustomerCode==this.customerCode); }
        }
        public OrderStatus OrderStatusHelp
        {
            get {return MyDB.ordersStatus.GetList().FirstOrDefault(x=>x.StatusCode==this.status); }
        }
        #region Properties
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
        public int  Status
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
        public int FinalPrice
        {
            get
            {
                return this.finalPrice;
            }
            set
            {
                this.finalPrice = value;
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
        #endregion
        public override void FillDataRow()
        {
            row["orderCode"] = this.orderCode;
            row["customerCode"] = this.customerCode;
            row["orderDate"] = this.orderDate;
            row["parkingCode"] = this.parkingCode;
            row["fromAnHour"] = this.fromAnHour;
            row["toAnHour"] = this.toAnHour;
            row["status"] = this.status;
            row["finalPrice"] = this.finalPrice;
        }
        protected override void FillFields()
        {
            this.customerCode = Convert.ToInt32(row["customerCode"]);
            this.orderCode = Convert.ToInt32(row["orderCode"]);
            this.parkingCode = Convert.ToInt32(row["parkingCode"]);
            this.status = Convert.ToInt32(row["status"]);
            this.fromAnHour = Convert.ToDateTime(row["fromAnHour"]);
            this.toAnHour = Convert.ToDateTime(row["toAnHour"]);
            this.OrderDate = Convert.ToDateTime(row["OrderDate"]);
            this.finalPrice = Convert.ToInt32(row["finalPrice"]);

        }
    }
}
