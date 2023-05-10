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
    public partial class frmEnterToPark : Form
    {
        public frmEnterToPark()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {
                if(MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text) != null)
                {
                    Customer customer = MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text);
                    ParkingOrder order = MyDB.parkingOrders.GetList().FirstOrDefault(x => x.CustomerCode == customer.CustomerCode && x.OrderDate.Date == DateTime.Today.Date && x.FromAnHour.TimeOfDay >= DateTime.Today.TimeOfDay);
                    if (order != null)
                    {
                        order.Status = 2;
                        MyDB.parkingOrders.UpdateItem(order);
                        MyDB.parkingOrders.SaveChanges();
                        MessageBox.Show("כניסתך עודכנה במערכת");
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
