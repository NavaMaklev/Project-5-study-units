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
    public partial class frmOneTimeAvailability : Form
    {
        private Parking park;
        private ParkingAvailability current;
        public frmOneTimeAvailability(Parking park)
        {
            this.park = park;
            InitializeComponent();
            lblAddress.Text = park.StreetHelp + " " + park.HouseNumber;
            lblCode.Text = park.ParkingCode.ToString();
            lblSize.Text = park.ParkingSizeHelp.ToString();
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "dd.MM.yyyy";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "dd.MM.yyyy";
            dtpFromHour.Format = DateTimePickerFormat.Custom;
            dtpFromHour.CustomFormat = "HH:mm";
            dtpFromHour.ShowUpDown = true;
            dtpToHour.Format = DateTimePickerFormat.Custom;
            dtpToHour.CustomFormat = "HH:mm";
            dtpToHour.ShowUpDown = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            current = new ParkingAvailability();
            fillObj();
            MyDB.parkingAvailability.AddItem(current);
            MyDB.parkingAvailability.SaveChanges();
            MessageBox.Show("נוסף בהצלחה");
        }
        private void fillObj()
        {
            current.AvailabilityCode = MyDB.parkingAvailability.GetNextKey();
            current.ParkingCode = park.ParkingCode;
            current.FromDate = dtpFromDate.Value;
            current.ToDate = dtpToDate.Value;
            current.FromAnHour = dtpFromHour.Value;
            current.ToAnHour = dtpToHour.Value;
        }
    }
}
