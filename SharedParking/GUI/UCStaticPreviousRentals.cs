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
    public partial class UCStaticPreviousRentals : UserControl
    {
        public UCStaticPreviousRentals()
        {
            InitializeComponent();
        }
        public UCStaticPreviousRentals(StaticOrder order)
        {
            InitializeComponent();
            txtcode.Text = order.OrderCode.ToString();
            txtname.Text = order.CustomerHelp.ToString();
            txtprice.Text = order.PricePerMonth.ToString();
            txtdatestart.Text = order.OrderDate.ToShortDateString();
            txtdateend.Text = order.EndDate.ToShortDateString();
                
        }
    }
}
