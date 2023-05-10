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
    public partial class frmExitFromPark : Form
    {
        public frmExitFromPark()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {
                if (MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text) != null)
                {
                    Customer customer = MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text);
                    ParkingOrder order = MyDB.parkingOrders.GetList().FirstOrDefault(x => x.CustomerCode == customer.CustomerCode && x.OrderDate.Date == DateTime.Today.Date && (x.ToAnHour.TimeOfDay <= DateTime.Today.TimeOfDay|| x.ToAnHour.TimeOfDay > DateTime.Today.TimeOfDay )&& x.Status==2);
                    if (order != null)
                    {
                        order.Status = 3;
                        MyDB.parkingOrders.UpdateItem(order);
                        MyDB.parkingOrders.SaveChanges();
                        MessageBox.Show("יציאתך עודכנה במערכת");
                        Payment payment = new Payment();
                        payment.PaymentCode = MyDB.payments.GetNextKey();
                        payment.CustomerCode = customer.CustomerCode;
                        payment.ParkingOwnerCode = MyDB.parking.GetList().FirstOrDefault(x => x.ParkingCode == order.ParkingCode).IdParkingOwner;
                        payment.FinalSum = order.FinalPrice;
                        payment.ChargeFor = "חניה פרטית";
                        payment.PaymentDate = order.OrderDate;
                        MyDB.payments.AddItem(payment);
                        MyDB.payments.SaveChanges();
                        MessageBox.Show("תשלומך התקבל");
                    }
                    else
                        MessageBox.Show("לא נמצאה הזמנת חניה");
                }
                else
                {
                    MessageBox.Show("מספר הטלפון שהקשת אינו קיים במערכת,הקש שנית");
                    txtPhone.Clear();
                }
            }
        }
    }
}
