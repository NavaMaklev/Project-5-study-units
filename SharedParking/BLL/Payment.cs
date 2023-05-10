using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class Payment: GeneralRow
    {
        private int paymentCode;
        private int customerCode;
        private string parkingOwnerCode;
        private int finalSum;
        private string chargeFor;
        private DateTime paymentDate;
        public Payment() { }
        public Payment(DataRow row) : base(row) { }
        public Customer CustomerHelp
        {
            get { return MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == this.customerCode); }
        }
        public ParkingOwner ParkingOwnerHelp
        {
            get { return MyDB.parkingOwners.GetList().FirstOrDefault(x => x.Id == this.parkingOwnerCode); }
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
        public int PaymentCode
        {
            get
            {
                return this.paymentCode;
            }
            set
            {
                this.paymentCode = value;
            }
        }
        public string ParkingOwnerCode
        {
            get
            {
                return this.parkingOwnerCode;
            }
            set
            {
                this.parkingOwnerCode = value;
            }
        }
        public string ChargeFor
        {
            get
            {
                return this.chargeFor;
            }
            set
            {
                this.chargeFor = value;
            }
        }
        public int FinalSum
        {
            get
            {
                return this.finalSum;
            }
            set
            {
                this.finalSum = value;
            }
        }
        public DateTime PaymentDate
        {
            get
            {
                return this.paymentDate;
            }
            set
            {
                this.paymentDate = value;
            }
        }
       
        #endregion
        public override void FillDataRow()
        {
            row["customerCode"] = this.customerCode;
            row["paymentCode"] = this.paymentCode;
            row["parkingOwnerCode"] = this.parkingOwnerCode;
            row["finalSum"] = this.finalSum;
            row["chargeFor"] = this.chargeFor;
            row["paymentDate"] = this.paymentDate;
        }
        protected override void FillFields()
        {
            this.customerCode = Convert.ToInt32(row["customerCode"]);
            this.parkingOwnerCode = row["parkingOwnerCode"].ToString();
            this.chargeFor = row["chargeFor"].ToString();
            this.finalSum = Convert.ToInt32( row["finalSum"]);
            this.paymentDate = Convert.ToDateTime(row["paymentDate"]);
            this.paymentCode = Convert.ToInt32(row["paymentCode"]);
        }
    }
}
