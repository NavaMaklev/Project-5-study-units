using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedParking.BLL;

namespace SharedParking.GUI
{
    public partial class UCcancelOnceOrder : UserControl
    {
        private int code;
        public UCcancelOnceOrder(int code,DateTime date,DateTime from,DateTime to)
        {
            InitializeComponent();
            this.code = code;
            lblDate.Text = date.ToShortDateString();
            lblFrom.Text = from.ToShortTimeString();
            lblTo.Text = to.ToShortTimeString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ParkingOrder order = MyDB.parkingOrders.GetList().FirstOrDefault(x => x.OrderCode == code);
            DialogResult result = MessageBox.Show("הינך עומד לבטל הזמנה ", "ביטול", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //מחיקה
                MyDB.parkingOrders.DeleteItem(order);
                MyDB.parkingOrders.SaveChanges();
                this.Visible = false;
                MessageBox.Show("הזמנתך בוטלה");
            }
        }
    }
}
