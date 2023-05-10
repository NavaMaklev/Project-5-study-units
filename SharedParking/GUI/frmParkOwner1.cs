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
    public partial class frmParkOwner1 : Form
    {
        public frmParkOwner1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!Validation.CheckId(txtId.Text) || !Validation.IsPelephon(txtPhone.Text))
            {
                MessageBox.Show("פרטים שגויים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Clear();
                txtPhone.Clear();
            }
            else
            {

                if (MyDB.parkingOwners.GetList().FirstOrDefault(x => x.Id == txtId.Text && x.PhoneNumber == txtPhone.Text) == null)
                {
                    frmParkOwner po = new frmParkOwner(txtId.Text,txtPhone.Text);
                    po.Show();
                }
                else
                {
                    frmMainParkOwner fmpo = new frmMainParkOwner(txtId.Text, MyDB.parkingOwners.GetList().First(x => x.Id == txtId.Text).OwnerName);
                    fmpo.Show();
                }
            }
        }
    }
}
