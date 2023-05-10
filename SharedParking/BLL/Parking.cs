using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SharedParking.BLL
{
    public class Parking : GeneralRow
    {
        private int parkingCode;
        private string idParkingOwner;
        private int parkingSize;
        private int street;
        private string houseNumber;
        private string location;
        private int area;
        private double pricePerHour;
        private bool parkingStatus;
        public Parking() { }
        public Parking(DataRow row) : base(row) { }
        public Area AreaHelp
        {
            get {return MyDB.areas.GetList().FirstOrDefault(x=>x.AreaCode==this.area); }
        }
        public Street StreetHelp
        {
            get {return MyDB.streets.GetList().FirstOrDefault(x=>x.StreetCode==this.street); }
        }
        public ParkingOwner ParkingOwnerHelp
        {
            get {return MyDB.parkingOwners.GetList().FirstOrDefault(x=>x.Id==this.idParkingOwner); }
        }
        public ParkingSize ParkingSizeHelp
        {
            get { return MyDB.parkingSize.GetList().FirstOrDefault(x => x.SizeCode == this.parkingSize); }
        }
        #region Properties
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
        public string IdParkingOwner
        {
            get
            {
                return this.idParkingOwner;
            }
            set
            {
                this.idParkingOwner = value;
            }
        }
        public int Street
        {
            get
            {
                return this.street;
            }
            set
            {
                this.street = value;
            }
        }
        public string HouseNumber
        {
            get
            {
                return this.houseNumber;
            }
            set
            {
                this.houseNumber = value;
            }
        }
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }
        public int Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }
        public double PricePerHour
        {
            get
            {
                return this.pricePerHour;
            }
            set
            {
                this.pricePerHour = value;
            }
        }

        public bool PakingStatus
        {
            get { return this.parkingStatus; }
            set { this.parkingStatus = value; }
        }

        public bool ParkingStatus { get => parkingStatus; set => parkingStatus = value; }
        #endregion
        public override void FillDataRow()
        {
            row["parkingCode"] = this.parkingCode;
            row["idParkingOwner"] = this.idParkingOwner; 
            row["parkingSize"] = this.parkingSize;
            row["street"] = this.street;
            row["houseNumber"] = this.houseNumber;
            row["location"] = this.location;
            row["area"] = this.area;
            row["pricePerHour"] = this.pricePerHour;
            row["parkingStatus"] = this.parkingStatus;

        }

        protected override void FillFields()
        {
            this.parkingCode = Convert.ToInt32(row["parkingCode"]);
            this.parkingSize = Convert.ToInt32(row["parkingSize"]);
            this.street = Convert.ToInt32(row["street"]);
            this.area = Convert.ToInt32(row["area"]);
            this.idParkingOwner = row["idParkingOwner"].ToString();
            this.houseNumber = row["houseNumber"].ToString();
            this.location = row["location"].ToString();
            this.pricePerHour = Convert.ToDouble( row["pricePerHour"]);
            this.parkingStatus = Convert.ToBoolean( row["parkingStatus"]);
        }

        //זמינות חד פעמית
        public bool IsAvailable(DateTime date, DateTime fromHour, DateTime toHour)
        {
            //בדיקה אם יש זמינות כללית
            if (MyDB.parkingAvailability.GetList().Exists(x => x.ParkingCode == this.ParkingCode && x.FromDate.Date <= date.Date && x.ToDate.Date >= date.Date && x.FromAnHour.ClearSeconds().TimeOfDay <= fromHour.TimeOfDay && x.ToAnHour.ClearSeconds().TimeOfDay >= toHour.TimeOfDay))
            {
                //בדיקה אם לא הוזמן או תפוס עכשיו
                if (MyDB.parkingOrders.GetList().Exists(x => (x.ParkingCode==this.ParkingCode&&x.OrderDate == date) && (fromHour > x.FromAnHour && fromHour < x.ToAnHour) || (toHour > x.FromAnHour && toHour < x.ToAnHour)))
                    return false;
                return true;
            }
            else
                return false;
        }
        //זמינות קבועה
        public bool IsAvailable(string day, DateTime fromHour, DateTime toHour)
        {
            List<StaticOrder> lst = new List <StaticOrder>();
            //בדיקה אם יש זמינות כללית
            if (MyDB.permanentAvailability.GetList().Exists(x=>x.ParkingCode==this.parkingCode&&x.DayInWeek==day&&x.FromAnHour.ClearSeconds().TimeOfDay<=fromHour.ClearSeconds().TimeOfDay&&x.ToAnHour.ClearSeconds().TimeOfDay>=toHour.ClearSeconds().TimeOfDay))
            {
                //בדיקה אם לא הוזמן או תפוס 
                lst = MyDB.staticOrders.GetList().FindAll(x => x.ParkingCode == this.ParkingCode).ToList();
                lst = lst.Where(x => x.DayInWeek == day).ToList();
                if(!(lst.Exists(x=>x.EndDate.Date<DateTime.Today.Date)))
                {
                    lst = lst.Where(x => (x.FromAnHour.ClearSeconds().TimeOfDay >= fromHour.ClearSeconds().TimeOfDay && x.FromAnHour.ClearSeconds().TimeOfDay <= toHour.ClearSeconds().TimeOfDay) || (x.FromAnHour.ClearSeconds().TimeOfDay <= fromHour.ClearSeconds().TimeOfDay && x.ToAnHour.ClearSeconds().TimeOfDay >= fromHour.ClearSeconds().TimeOfDay)).ToList();
                        if (lst.Count > 0)
                            return false;   
                }
                return true;
            }
            else
               return false;
        }
    }
}
