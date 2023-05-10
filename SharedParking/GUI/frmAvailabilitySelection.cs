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
    public partial class frmAvailabilitySelection : Form
    {
        private Parking park;
        public frmAvailabilitySelection(Parking park)
        {
            InitializeComponent();
            this.park = park;
        }

        private void btnOneTimeAvailability_Click(object sender, EventArgs e)
        {
            frmOneTimeAvailability oneTimeAvailability = new frmOneTimeAvailability(park);
            oneTimeAvailability.Show();
        }

        private void btnPermanentAvailability_Click(object sender, EventArgs e)
        {
            frmPermanentAvailability permanentAvailability = new frmPermanentAvailability(park);
            permanentAvailability.Show();
        }
    }
}
