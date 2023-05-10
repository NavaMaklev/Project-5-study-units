using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class ParkingOwner:GeneralRow
    {
        private string id;
        private string ownerName;
        private string phoneNumber;
        private string bank;
        private int branch;//מה לעשות עם זה??
        private string accountNumber;
        public ParkingOwner() { }
        public ParkingOwner(DataRow row) : base(row) { }
        #region Properties
       public int Branch
        {
            get
            {
                return this.branch;
            }
            set
            {
                this.branch = value;
            }
        }
       
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
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
        public string OwnerName
        {
            get
            {
                return this.ownerName;
            }
            set
            {
                this.ownerName = value;
            }
        }
        public string Bank
        {
            get
            {
                return this.bank;
            }
            set
            {
                this.bank = value;
            }
        }
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                this.accountNumber = value;
            }
        }
        #endregion
        public override void FillDataRow()
        {
            row["id"] = this.id;
            row["ownerName"] = this.ownerName;
            row["phoneNumber"] = this.phoneNumber;
            row["bank"] = this.bank;
            row["Branch"] = this.branch;
            row["accountNumber"] = this.accountNumber;
        }
        protected override void FillFields()
        {
            this.branch = Convert.ToInt32(row["Branch"]);
            this.id = row["id"].ToString();
            this.phoneNumber = row["phoneNumber"].ToString();
            this.ownerName = row["ownerName"].ToString();
            this.bank = row["bank"].ToString();
            this.accountNumber = row["accountNumber"].ToString();
        }
        public override string ToString()
        {
            return ownerName;
        }
    }
}
