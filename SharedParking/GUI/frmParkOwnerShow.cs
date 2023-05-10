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
    public partial class frmParkOwnerShow : Form
    {
        public frmParkOwnerShow()
        {
            InitializeComponent();
            dgvParkOwner.DataSource = MyDB.parkingOwners.GetList().ToList();
        }

        private void dgvParkOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
