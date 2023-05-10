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
    public partial class UCOrder : UserControl
    {
        public UCOrder(int code,DateTime date,DateTime fromHour,DateTime toHour,double price)
        {
            int hours, minute;
            double sum;
            InitializeComponent();
            lblParkCode.Text = code.ToString();
            lblDate.Text = date.ToString("dd.MM"); 
            lblFrom.Text = fromHour.ToShortTimeString();
            lblTo.Text = toHour.ToShortTimeString();
            hours = ((toHour - fromHour).Hours);
            minute = (Math.Abs((toHour - fromHour).Minutes));
            sum = ((hours * price) + ((price / 60) * minute)) ;
            lblPrice.Text = sum.ToString();
        }
    }
}
