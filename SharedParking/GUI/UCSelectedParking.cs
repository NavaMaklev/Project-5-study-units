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
    public partial class UCSelectedParking : UserControl
    {
       static private bool once = false,statics=false;
        private DateTime date ,fromHour, toHour;
        private string day;
        private Parking currentPark;
        public UCSelectedParking()
        {
            InitializeComponent();
        }
        public UCSelectedParking(Parking park)
        {
            currentPark = park;
            InitializeComponent();
            fillFields();
        }
        public void keepDetails(DateTime date, DateTime fromHour, DateTime toHour)
        {
            once = true;
            statics =false;
            this.date = date;
            this.fromHour = fromHour;
            this.toHour = toHour;
        }
        public void keepDetails(string day, DateTime fromHour, DateTime toHour)
        {
            statics = true;
            once = false;
            this.day = day;
            this.fromHour = fromHour;
            this.toHour = toHour;
        }
        private void fillFields()
        {
            txtStreet.Text = currentPark.StreetHelp.ToString();
            txtLoc.Text = currentPark.Location;
            txtSize.Text = currentPark.ParkingSizeHelp.ToString();
            txtPrice.Text = currentPark.PricePerHour.ToString();
            txtCodePark.Text = currentPark.ParkingCode.ToString();
        }

        private void cbOk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOk.Checked == true)
            {
                if (once)
                {
                    frmParkingOrder order = new frmParkingOrder(Convert.ToInt32(this.txtCodePark.Text),date,fromHour,toHour,Convert.ToInt32(this.txtPrice.Text));
                    order.Show();
                }
                else if(statics)
                {
                    frmParkingOrder order = new frmParkingOrder(Convert.ToInt32(this.txtCodePark.Text), day, fromHour, toHour, Convert.ToInt32(this.txtPrice.Text));
                    order.Show();
                }
            }
        }
    }
}
