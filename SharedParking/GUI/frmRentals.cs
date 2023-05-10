using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedParking.BLL;

namespace SharedParking.GUI
{
    public partial class frmRentals : Form
    {
        public frmRentals(Parking park)
        {
            InitializeComponent();
            lblCode.Text = park.ParkingCode.ToString();
            lblAddress.Text = MyDB.streets.GetList().FirstOrDefault(x => x.StreetCode == park.Street).StreetName + " " + park.HouseNumber;
            lblSize.Text = MyDB.parkingSize.GetList().FirstOrDefault(z => z.SizeCode == park.ParkingSize).SizeName;
            StaticOrder staticOrder = MyDB.staticOrders.GetList().FirstOrDefault(x => x.ParkingCode == park.ParkingCode && x.Status == 2&&x.FromAnHour.TimeOfDay<=DateTime.Today.TimeOfDay&&x.ToAnHour.TimeOfDay>=DateTime.Today.TimeOfDay);
            ParkingOrder parkingOrder = MyDB.parkingOrders.GetList().FirstOrDefault(x => x.ParkingCode == park.ParkingCode && x.Status == 2 && x.FromAnHour.TimeOfDay <= DateTime.Today.TimeOfDay && x.ToAnHour.TimeOfDay >= DateTime.Today.TimeOfDay);
            //מילוי פרטי משתמש בגרופבוקס בתנאי שהחניה בשימוש כרגע
            if(staticOrder!=null)
            {
                lblCodeUser.Text = staticOrder.CustomerCode.ToString();
                lblName.Text = MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == staticOrder.CustomerCode).CustomerName;
                lblPhone.Text= MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == staticOrder.CustomerCode).PhoneNumber;
                groupBox1.Visible = true;
            }
            else if(parkingOrder!=null)
            {
                lblCodeUser.Text = parkingOrder.CustomerCode.ToString();
                lblName.Text = MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == parkingOrder.CustomerCode).CustomerName;
                lblPhone.Text = MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == parkingOrder.CustomerCode).PhoneNumber;
                groupBox1.Visible = true;
            }
            List<ParkingOrder> parkingOrders = MyDB.parkingOrders.GetList().FindAll(x => x.ParkingCode == park.ParkingCode && x.Status == 3).ToList();
            List<StaticOrder> staticOrders = MyDB.staticOrders.GetList().FindAll(x => x.ParkingCode == park.ParkingCode && x.Status == 3).ToList();
            foreach (var item in parkingOrders)
            {
                UCPreviousRentals once = new UCPreviousRentals(item);
                flponce.Controls.Add(once);
            }
            foreach (var item in staticOrders)
            {
                UCStaticPreviousRentals staticRental = new UCStaticPreviousRentals(item);
                flpstatic.Controls.Add(staticRental);
            }
            if(parkingOrders.Count==0)
            {
                UCNotFound notFound = new UCNotFound();
                flponce.Controls.Add(notFound);
            }
            if (staticOrders.Count == 0)
            {
                UCNotFound notFound = new UCNotFound();
                flpstatic.Controls.Add(notFound);
            }
            lblSumRentls.Text = ((flpstatic.Controls.Count)+(flponce.Controls.Count)-2).ToString();
            int sum = 0;
            foreach (var item in parkingOrders)
            {
                sum += (int)(item.FinalPrice);
            }
            foreach (var item in staticOrders)
            {
                sum+= (int)(item.PricePerMonth);
            }
            lblSumPrice.Text = sum.ToString();
        }
    }
}
