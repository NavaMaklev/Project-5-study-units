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
    public partial class frmPermanentAvailability : Form
    {
        private PermanentAvailability pa;
        private Parking park;
       private List<PermanentAvailability> lst;
        public frmPermanentAvailability(Parking park)
        {
            InitializeComponent();
            this.park = park;
            dtpFromHour.Format = DateTimePickerFormat.Custom;
            dtpFromHour.CustomFormat = "HH:mm";
            dtpFromHour.ShowUpDown = true;
            dtpToHour.Format = DateTimePickerFormat.Custom;
            dtpToHour.CustomFormat = "HH:mm";
            dtpToHour.ShowUpDown = true;
           lst = MyDB.permanentAvailability.GetList().Where(x=>x.ParkingCode==park.ParkingCode).ToList();
            foreach (var item in lst)
            {
                UCpermanetAvailability permanet = new UCpermanetAvailability(item);
                flpActiveAvailability.Controls.Add(permanet);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pa = new PermanentAvailability();
            fillObj();
            MyDB.permanentAvailability.AddItem(pa);
            MyDB.permanentAvailability.SaveChanges();
            UCpermanetAvailability permanet = new UCpermanetAvailability(pa);
            flpActiveAvailability.Controls.Add(permanet);
            MessageBox.Show("הזמינות נוספה");
        }
        private void fillObj()
        {
            pa.Code = MyDB.permanentAvailability.GetNextKey();
            pa.ParkingCode = park.ParkingCode;
            pa.DayInWeek = cmbDay.SelectedItem.ToString();
            pa.FromAnHour = dtpFromHour.Value.AddSeconds(-(dtpFromHour.Value.Second)); ;
            pa.ToAnHour = dtpToHour.Value.AddSeconds(-(dtpToHour.Value.Second));
        }
    }
}
