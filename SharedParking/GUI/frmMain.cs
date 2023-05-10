using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedParking.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void btnParkingOwner_Click(object sender, EventArgs e)
        {
            frmParkOwner1 fpo1 = new frmParkOwner1();
            fpo1.Show();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
           frmMenger menger = new frmMenger();
            menger.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmMainCustomer mainCustomer = new frmMainCustomer();
            mainCustomer.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
