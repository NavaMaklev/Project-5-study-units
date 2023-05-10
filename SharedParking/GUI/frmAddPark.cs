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
    public partial class frmAddPark : Form
    {
        private ParkingOwner owner;
        private Parking currentPark;
        public frmAddPark(ParkingOwner owner)
        {
            InitializeComponent();
            this.owner = owner;
            cmbAddress.DataSource = MyDB.streets.GetList();
            cmbSize.DataSource = MyDB.parkingSize.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentPark = new Parking();
            fillObj();
            MyDB.parking.AddItem(currentPark);
            MyDB.parking.SaveChanges();
            MessageBox.Show("החניה נוספה למאגר");
            frmAvailabilitySelection availabilitySelection = new frmAvailabilitySelection(currentPark);
            availabilitySelection.Show();
           
        }
        private void fillObj()
        {
            currentPark.ParkingCode = MyDB.parking.GetNextKey();
            currentPark.IdParkingOwner = owner.Id;
           currentPark.ParkingSize = ((ParkingSize)cmbSize.SelectedItem).SizeCode;
            currentPark.Street = ((Street)cmbAddress.SelectedItem).StreetCode;
            currentPark.HouseNumber = txtHouseNum.Text;
            currentPark.Location = rtbLoc.Text;
            currentPark.Area = ((Street)cmbAddress.SelectedItem).AreaCode;
            currentPark.PricePerHour = Convert.ToDouble(txtPrice.Text);
            currentPark.ParkingStatus = true;
        }

        private void cmbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtArea.Text = ((Street)cmbAddress.SelectedItem).AreaHelp.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
