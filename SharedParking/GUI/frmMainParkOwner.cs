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
    
    public partial class frmMainParkOwner : Form
    {
        Parking current;
        List<ParkingSize> lstParkSize = MyDB.parkingSize.GetList();
        List<Street> lstStreet = MyDB.streets.GetList();
        public frmMainParkOwner()
        {
            InitializeComponent();
        }
        public frmMainParkOwner(string id,string name)
        {
            InitializeComponent();
            lblName.Text = name;
            lblDate.Text = DateTime.Today.ToString("dd.MM.yyyy");

            dgvMyParking.DataSource = MyDB.parking.GetList().Where(x => x.IdParkingOwner == id).Select(x => new
            {
                קוד = x.ParkingCode,
                כתובת = lstStreet.FirstOrDefault(z=>z.StreetCode==x.Street).StreetName + " " + x.HouseNumber,
                גודל =  lstParkSize.First(y => y.SizeCode == x.ParkingSize).SizeName
            })
            .ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            current = MyDB.parking.GetList().FirstOrDefault(x => x.ParkingCode == Convert.ToUInt32(dgvMyParking.CurrentRow.Cells[0].Value));
            frmParkOptions frmpo = new frmParkOptions(current);
            frmpo.Show();
        }

        private void dgvMyParking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
