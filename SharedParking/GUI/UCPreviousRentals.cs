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
    public partial class UCPreviousRentals : UserControl
    {
        public UCPreviousRentals()
        {
            InitializeComponent();
        }
        public UCPreviousRentals(ParkingOrder order)
        {
            InitializeComponent();
            txtcode.Text = order.OrderCode.ToString();
            txtname.Text = order.CustomerHelp.ToString();
            txtstatus.Text = order.OrderStatusHelp.ToString();
            txtprice.Text = order.FinalPrice.ToString();
            txtdate.Text = order.OrderDate.ToShortDateString();
        }
    }
}
