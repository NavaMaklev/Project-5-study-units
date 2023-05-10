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
    public partial class frmCancelOrder : Form
    {
        public frmCancelOrder()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            List<ParkingOrder> parkingOrders;
            int customerCode;
            if (txtPhone.Text.Length == 10)
            {
                if (MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text) != null)
                {
                    customerCode = MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text).CustomerCode;
                   
                    parkingOrders = MyDB.parkingOrders.GetList().Where(x => x.CustomerCode == customerCode && (DateTime.Today <x.OrderDate|| DateTime.Today==x.OrderDate&& DateTime.Today.Hour+2<=x.FromAnHour.Hour)).ToList();
                   
                    foreach (var item in parkingOrders)
                    {
                        UCcancelOnceOrder cancel = new UCcancelOnceOrder(item.OrderCode,item.OrderDate,item.FromAnHour,item.ToAnHour);
                        flpOnceOrder.Controls.Add(cancel);
                    }
                   
                    if (parkingOrders.Count == 0)
                    {
                        UCNotFound notFound = new UCNotFound();
                        flpOnceOrder.Controls.Add(notFound);
                    }
                    UCMessege messege = new UCMessege();
                    flpStaticOrders.Controls.Add(messege);
                    grbMyOrders.Visible = true;
                }
                else
                    MessageBox.Show("מספר הטלפון לא קיים במערכת,הקש שנית");
            }
        }
    }
}
