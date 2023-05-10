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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            
            dgvCustomers.DataSource = MyDB.customers.GetList().OrderBy(x => x.CustomerName).Select(x => new
            {
                customerName=x.CustomerName,
                phoneNumber=x.PhoneNumber,
                creditNumber=x.CreditNumber,
                validity=x.Validity,
                idOfTheCardHolder=x.IdOfTheCardholder
            }).ToList();
           
           

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = new Customer();
            customer = MyDB.customers.GetList().FirstOrDefault(x => x.CustomerCode == Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString()));

            frmCustomer frm = new frmCustomer(customer);
            frm.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            //רענון תצוגה לאחר הוספה
            dgvCustomers.DataSource = MyDB.customers.GetList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           dgvCustomers.DataSource = MyDB.customers.GetList().Where(x => (x.CustomerName).StartsWith(txtSearch.Text)).OrderBy(x => x.CustomerName).ToList();
        }

        private void btnAppdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer = MyDB.customers.GetList().First(x => x.CustomerCode == Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString()));

            frmCustomer frm = new frmCustomer(customer);
            frm.ShowDialog();
            //רענון תצוגה לאחר הוספה
            dgvCustomers.DataSource = MyDB.customers.GetList();
        }
    }
}
