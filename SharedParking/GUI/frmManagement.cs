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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmData data = new frmData();
            data.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPayments payments = new frmPayments();
            payments.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmParkOwnerShow show = new frmParkOwnerShow();
            show.Show();
        }
    }
}
