using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class Customer : GeneralRow
    {
        private int customerCode;
        private string customerName;
        private string phoneNumber;
        private string carDetails;
        private int parkingSize;
        private string icenseNumber;
        private string creditNumber;
        private DateTime validity;
        private string idOfTheCardholder;
        public Customer() { }
        public Customer(DataRow row) : base(row) { }
        public ParkingSize ParkingSizeHelp
        {
            get{return MyDB.parkingSize.GetList().FirstOrDefault(x => x.SizeCode==this.parkingSize); }
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
        public int ParkingSize
        {
            get
            {
                return this.parkingSize;
            }
            set
            {
                this.parkingSize = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return this.customerName;
            }
            set
            {
                this.customerName = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public string CarDetails
        {
            get
            {
                return this.carDetails;
            }
            set
            {
                this.carDetails = value;
            }
        }
        public string IcenseNumber
        {
            get
            {
                return this.icenseNumber;
            }
            set
            {
                this.icenseNumber = value;
            }
        }
        public string CreditNumber
        {
            get
            {
                return this.creditNumber;
            }
            set
            {
                this.creditNumber = value;
            }
        }
        public string IdOfTheCardholder
        {
            get
            {
                return this.idOfTheCardholder;
            }
            set
            {
                this.idOfTheCardholder = value;
            }
        }
         public DateTime Validity
        {
            get
            {
                return this.validity;
            }
            set
            {
                this.validity = value;
            }
        }
        #endregion
        public override void FillDataRow()
        {
            row["customerCode"] = this.customerCode;
            row["customerName"] = this.customerName;
            row["phoneNumber"] = this.phoneNumber;
            row["carDetails"] = this.carDetails;
            row["parkingSize"] = this.parkingSize;
            row["icenseNumber"] = this.icenseNumber;
            //לנסות לשנות--- אות גדולה***
            row["CreditNumber"] = this.creditNumber;
            row["validity"] = this.validity;
            row["idOfTheCardholder"] = this.idOfTheCardholder;
        }
        protected override void FillFields()
        {
            this.customerCode = Convert.ToInt32(row["customerCode"]);
            this.customerName = row["customerName"].ToString();
            this.phoneNumber = row["phoneNumber"].ToString();
            this.carDetails = row["carDetails"].ToString();
            this.icenseNumber = row["icenseNumber"].ToString();
            //לשנות אות גדולה****
            this.creditNumber = row["CreditNumber"].ToString();
            this.idOfTheCardholder = row["idOfTheCardholder"].ToString();
            this.validity =Convert.ToDateTime( row["validity"]);
            this.parkingSize = Convert.ToInt32( row["parkingSize"]);
        }
        public override string ToString()
        {
            return customerName;
        }
    }
}
