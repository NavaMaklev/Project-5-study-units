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
    public partial class frmParkingOrder : Form
    {
        int hours, minute;
        private int typeOrder; private int price;
        private Customer currentCustomer;
        private Parking p;
        private DateTime dateParking;
        private DateTime fromH, toH;
        private string dayP;
        public frmParkingOrder(int codePark, DateTime date , DateTime from, DateTime to, int price)
        {
            InitializeComponent();
            this.price = price;
            typeOrder = 1;
            p = MyDB.parking.GetList().FirstOrDefault(x => x.ParkingCode == codePark);
            this.dateParking = date;
            this.fromH = from;
            this.toH = to;
            UCOrder order = new UCOrder(codePark, date, from, to, price);
            flpOrderDetails.Controls.Add(order);
        }
        public frmParkingOrder(int codePark, string day, DateTime from, DateTime to,int price)
        {
            InitializeComponent();
            this.price = price;
            typeOrder = 2;
            p = MyDB.parking.GetList().FirstOrDefault(x => x.ParkingCode == codePark);
            this.dayP = day;
            this.fromH = from;
            this.toH = to;
            dateParking = DateTime.Today;
            UCStaticOrder staticOrder = new UCStaticOrder(codePark, day, from, to, price);
            flpOrderDetails.Controls.Add(staticOrder);
        }
       
        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length == 10)
            {
                if (MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text) == null)
                {
                    frmCustomer customer = new frmCustomer(txtPhone.Text);
                    customer.ShowDialog();
                    currentCustomer = MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text);
                    txtName.Text = currentCustomer.CustomerName;
                    txtCarDetails.Text = currentCustomer.CarDetails;
                    txtSizeParking.Text = currentCustomer.ParkingSizeHelp.ToString();
                    grpDetails.Visible = true;
                }
                else
                {
                    currentCustomer = MyDB.customers.GetList().FirstOrDefault(x => x.PhoneNumber == txtPhone.Text);
                    txtName.Text = currentCustomer.CustomerName;
                    txtCarDetails.Text = currentCustomer.CarDetails;
                    txtSizeParking.Text = currentCustomer.ParkingSizeHelp.ToString();
                    grpDetails.Visible = true;
                }

                if (p.ParkingSize < currentCustomer.ParkingSize)
                {
                    MessageBox.Show("גודל החניה שבחרת קטן מהגודל הנדרש לרכבך....");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // בדיקה האם חניה קבועה או זמנית
            ParkingOrder onceOrder = new ParkingOrder();
            StaticOrder staticOrder = new StaticOrder();
         if(typeOrder==1)
            {
                //הזמנת חניה חד פעמית
                //הוספה לטבלת ההזמנות
                onceOrder.OrderCode = MyDB.parkingOrders.GetNextKey();
                onceOrder.CustomerCode = currentCustomer.CustomerCode;
                onceOrder.FromAnHour = fromH.AddSeconds(-(fromH.Second));
                onceOrder.ToAnHour = toH.AddSeconds(-(toH.Second));
                onceOrder.OrderDate = dateParking;
                onceOrder.ParkingCode = p.ParkingCode;
                //חישוב הסכום לתשלום
                hours = ((toH - fromH).Hours);
                minute = (Math.Abs((toH - fromH).Minutes));
                price = ((hours * price) + ((price / 60) * minute));
                onceOrder.FinalPrice = price;
                onceOrder.Status = 1;
                //הוספה לטבלת ההזמנות
                MyDB.parkingOrders.AddItem(onceOrder);
                MyDB.parkingOrders.SaveChanges();
                MessageBox.Show("ההזמנה נקלטה במערכת");
            }
         else
            {
                //הזמנה קבועה
                
                staticOrder.OrderCode = MyDB.staticOrders.GetNextKey();
                staticOrder.CustomerCode = currentCustomer.CustomerCode;
                staticOrder.FromAnHour = fromH.AddSeconds(-(fromH.Second));
                staticOrder.ToAnHour = toH.AddSeconds(-(toH.Second));
                staticOrder.PricePerMonth =  (int)price;
                staticOrder.ParkingCode = p.ParkingCode;
                staticOrder.Status = 2;
                staticOrder.OrderDate = dateParking;
                staticOrder.EndDate = dateParking.AddDays(30);
                staticOrder.DayInWeek = dayP;
                //הוספה לטבלת ההזמנות
                MyDB.staticOrders.AddItem(staticOrder);
                MyDB.staticOrders.SaveChanges();
                //הוספה לטבלת התשלומים
                Payment payment = new Payment();
                payment.PaymentCode = MyDB.payments.GetNextKey();
                payment.CustomerCode = currentCustomer.CustomerCode;
                payment.ChargeFor = "חניה קבועה";
                payment.PaymentDate = dateParking;
                payment.ParkingOwnerCode = p.IdParkingOwner;
                //חישוב הסכום לתשלום
                hours = ((toH - fromH).Hours);
                minute = (Math.Abs((toH - fromH).Minutes));
                price = (int)((hours * 0.9 * price) + ((0.9 * price / 60) * minute)) * 4;
                payment.FinalSum = price;
                MyDB.payments.AddItem(payment);
                MyDB.payments.SaveChanges();
                MessageBox.Show("ההזמנה והתשלום נקלטו במערכת");

            }
        }
    }
}
