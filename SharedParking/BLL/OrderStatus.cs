using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class OrderStatus:GeneralRow
    {
        private int statusCode;
        private string statusName;
        public OrderStatus() { }
        public OrderStatus(DataRow row) : base(row) { }
        #region Properties
        public int StatusCode
        {
            get
            {
                return this.statusCode;
            }
            set
            {
                this.statusCode = value;
            }
        }
        public string StatusName
        {
            get
            {
                return this.statusName;
            }
            set
            {
                this.statusName = value;
            }
        }
        #endregion
        public override void FillDataRow()
        {
            row["statusCode"] = this.statusCode;
            row["statusName"] = this.statusName;
        }

        protected override void FillFields()
        {
            this.statusCode = Convert.ToInt32(row["statusCode"]);
            this.statusName = row["statusName"].ToString();
        }
        public override string ToString()
        {
            return statusName;
        }
    }
}
