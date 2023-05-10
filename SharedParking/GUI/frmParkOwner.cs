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
    public partial class frmParkOwner : Form
    {
        ParkingOwner currenParkingOwner;
        public frmParkOwner(string id,string phone)
        {
            InitializeComponent();
            txtId.Text = id;
            txtPhone.Text = phone;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            currenParkingOwner = new ParkingOwner();
            FillObj();
            MyDB.parkingOwners.AddItem(currenParkingOwner);
            MyDB.parkingOwners.SaveChanges();

            MessageBox.Show("ברכותינו! הינך במאגר");
            frmMainParkOwner fm = new frmMainParkOwner(currenParkingOwner.Id, currenParkingOwner.OwnerName);
            this.Close();
            
        }
        private void FillObj()
        {
            currenParkingOwner.Id = txtId.Text;
            currenParkingOwner.OwnerName = txtOwnerName.Text;
            currenParkingOwner.PhoneNumber = txtPhone.Text;
            currenParkingOwner.Bank = txtBank.Text;
            currenParkingOwner.Branch =Convert.ToInt32( txtBranch.Text);
            currenParkingOwner.AccountNumber = txtAccountNum.Text;
        }
    }
}
