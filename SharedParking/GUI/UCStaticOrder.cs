using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SharedParking.BLL
{
    public partial class UCStaticOrder : UserControl
    {
        int hours, minute;
        double sum;
        public UCStaticOrder(int code,string day,DateTime fromHour,DateTime toHour,double price)
        {
            InitializeComponent();
            lblParkCode.Text = code.ToString();
            lblDay.Text = day;
            lblFrom.Text = fromHour.ToShortTimeString();
            lblTo.Text = toHour.ToShortTimeString();
            hours = ((toHour-fromHour).Hours);
            minute = (Math.Abs((toHour - fromHour).Minutes));
            sum = ((hours * 0.9 * price)+((0.9 * price/60)*minute))*4;
            lblPrice.Text = sum.ToString();
        }

      
    }
}
