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
    public partial class frmParkOptions : Form
    {
        Parking park;
        ParkingOwner owner;
        public frmParkOptions(Parking park)
        {
            InitializeComponent();
            this.park = park;
            owner = MyDB.parkingOwners.GetList().FirstOrDefault(x => x.Id == park.IdParkingOwner);
        }

        private void btnPreviousRentals_Click(object sender, EventArgs e)
        {
            frmRentals rental = new frmRentals(park);
            rental.Show();
        }

        private void btnAddPark_Click(object sender, EventArgs e)
        {
            frmAddPark addPark = new frmAddPark(owner);
            addPark.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmParkOrders order = new frmParkOrders( park);
            order.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //החניה לא פעילה
            park.PakingStatus = false;
            MessageBox.Show("החניה לא זמינה להשכרה כרגע");
        }

        private void btnAvailabilityUpdate_Click(object sender, EventArgs e)
        {
            frmAvailabilitySelection availabilitySelection = new frmAvailabilitySelection(park);
            availabilitySelection.Show();
        }
    }
}
