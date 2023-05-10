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
    public partial class frmMainCustomer : Form
    {
        public frmMainCustomer()
        {
            InitializeComponent();
        }


        private void btnSearch_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            lblCancel.Visible = true;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            lblCancel.Visible = false;
        }

        private void btnIn_MouseHover(object sender, EventArgs e)
        {
            lblIn.Visible = true;
        }

        private void btnIn_MouseMove(object sender, MouseEventArgs e)
        {
            lblIn.Visible = false;
        }

        private void btnOut_MouseHover(object sender, EventArgs e)
        {
            lblOut.Visible = true;
        }

        private void btnOut_MouseMove(object sender, MouseEventArgs e)
        {
            lblOut.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmLookingForParking lookingForParking = new frmLookingForParking();
            lookingForParking.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmCancelOrder cancelOrder = new frmCancelOrder();
            cancelOrder.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmEnterToPark enter = new frmEnterToPark();
            enter.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmExitFromPark exit = new frmExitFromPark();
            exit.Show();
        }
    }
}
