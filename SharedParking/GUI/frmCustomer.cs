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
    public partial class frmCustomer : Form
    {
        FormState state;
        Customer currentCustomer;
        public frmCustomer()
        {
            InitializeComponent();
            cmbSize.DataSource = MyDB.parkingSize.GetList();
        }
        
        public frmCustomer(string phone)
        {
            InitializeComponent();
            cmbSize.DataSource = MyDB.parkingSize.GetList();
            state = FormState.Add;
            txtCusPhone.Text = phone;
        }
        public frmCustomer(Customer customer)
        {
            
            InitializeComponent();
            cmbSize.DataSource = MyDB.parkingSize.GetList();
            currentCustomer = customer;
            FillFormFields();
        }
        private void FillFormFields()
        {
           
            txtCusName.Text = currentCustomer.CustomerName;
            txtCusPhone.Text = currentCustomer.PhoneNumber;
            txtCarDetails.Text = currentCustomer.CarDetails;
            cmbSize.Text = currentCustomer.ParkingSizeHelp.ToString();
            txtCredNum.Text = currentCustomer.CreditNumber;
            dtpValid.Text = currentCustomer.Validity.ToString();
            txtIdCardHolder.Text = currentCustomer.IdOfTheCardholder;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (state == FormState.Add)
            {
                currentCustomer = new Customer();
                FillObj();
                MyDB.customers.AddItem(currentCustomer);
                MyDB.customers.SaveChanges();

                MessageBox.Show("הלקוח התווסף");
                
               
                this.Close();
            }

            else//Update
            {
                FillObj();
               MyDB.customers.UpdateItem(currentCustomer);
                MyDB.customers.SaveChanges();

                MessageBox.Show("השינויים נשמרו");
                this.Close();
            }
        }
        private void FillObj()
        { 
            currentCustomer.CustomerCode =MyDB.customers.GetNextKey();
            currentCustomer.CustomerName = txtCusName.Text;
            currentCustomer.PhoneNumber = txtCusPhone.Text;
            currentCustomer.CarDetails = txtCarDetails.Text;
            currentCustomer.ParkingSize = ((ParkingSize)cmbSize.SelectedItem).SizeCode;
            currentCustomer.IcenseNumber = txtIcNum.Text;
            currentCustomer.CreditNumber = txtCredNum.Text;
            currentCustomer.Validity =Convert.ToDateTime (dtpValid.Value);
            currentCustomer.IdOfTheCardholder = txtIdCardHolder.Text;
        }


    }
}

