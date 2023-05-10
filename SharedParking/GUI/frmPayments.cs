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
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
            dgvPayments.DataSource = MyDB.payments.GetList().Where(x => x.PaymentDate <= DateTime.Today).Select(x => new
            {
                paymentCode = x.PaymentCode,
                customerName = MyDB.customers.GetList().FirstOrDefault(y => y.CustomerCode == x.CustomerCode).CustomerName,
                customerPhone = MyDB.customers.GetList().FirstOrDefault(y => y.CustomerCode == x.CustomerCode).PhoneNumber,
                parkingOwnerName = MyDB.parkingOwners.GetList().FirstOrDefault(y => y.Id == x.ParkingOwnerCode).OwnerName,
                parkingOwnerPhone = MyDB.parkingOwners.GetList().FirstOrDefault(y => y.Id == x.ParkingOwnerCode).PhoneNumber,
                sum=x.FinalSum,
                chargeFor=x.ChargeFor,
                paymentDate=x.PaymentDate
            }
                    ).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
