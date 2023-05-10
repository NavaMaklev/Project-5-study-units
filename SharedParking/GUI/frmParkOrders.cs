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
    public partial class frmParkOrders : Form
    {
        //List<Street> lstStreet = MyDB.streets.GetList();
        public frmParkOrders(Parking park)
        {
            InitializeComponent();
            lblCode.Text = park.ParkingCode.ToString();
            lblAddress.Text = MyDB.streets.GetList().FirstOrDefault(x => x.StreetCode == park.Street).StreetName + " " + park.HouseNumber;
            lblSize.Text = MyDB.parkingSize.GetList().FirstOrDefault(z => z.SizeCode == park.ParkingSize).SizeName;
            List<ParkingOrder> once = null;
            List<StaticOrder> statics = null;
            once = MyDB.parkingOrders.GetList().FindAll(x => x.ParkingCode == park.ParkingCode&&x.Status==1).ToList();
            statics=MyDB.staticOrders.GetList().FindAll(x => x.ParkingCode == park.ParkingCode&&x.Status==2).ToList();
            foreach (var item in once)
            {
                UCPreviousRentals order = new UCPreviousRentals(item);
                flponce.Controls.Add(order);
            }
            foreach (var item in statics)
            {
                UCStaticPreviousRentals staticRental = new UCStaticPreviousRentals(item);
                flpstatic.Controls.Add(staticRental);
            }
            if(once.Count==0)
            {
                UCNotFound notFound = new UCNotFound();
                    flponce.Controls.Add(notFound);
            }
            if (statics.Count == 0)
            {
                UCNotFound notFound = new UCNotFound();
                flpstatic.Controls.Add(notFound);
            }
        }
    }
}
