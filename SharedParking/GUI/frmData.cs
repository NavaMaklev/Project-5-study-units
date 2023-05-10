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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
           if( cmbMonth.SelectedItem!=null && cmbYear.SelectedItem!=null)
            {
                fillLabels();
                groupBox1.Visible = true;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem != null && cmbYear.SelectedItem != null)
            {
                fillLabels();
                groupBox1.Visible = true;
            }
        }

        private void fillLabels()
        {
            txtSumStaticOrders.Text = MyDB.staticOrders.GetList().Count(x =>
            x.EndDate.Year == Convert.ToInt32(cmbYear.SelectedItem)&&
            x.EndDate.Month == Convert.ToInt32(cmbMonth.SelectedItem))
            .ToString();
            txtSumOrders.Text = MyDB.parkingOrders.GetList().Count(x =>
           x.OrderDate.Year == Convert.ToInt32(cmbYear.SelectedItem) &&
           x.OrderDate.Month == Convert.ToInt32(cmbMonth.SelectedItem))
           .ToString();

            List<Payment> x1 = MyDB.payments.GetList().Where(x =>
                x.PaymentDate.Year == Convert.ToInt32(cmbYear.SelectedItem) &&
               x.PaymentDate.Month == Convert.ToInt32(cmbMonth.SelectedItem)).ToList();

            txtSumMoney.Text = x1.Select(x => x.FinalSum).Sum().ToString();
        }
    }
}
