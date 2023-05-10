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
    public partial class frmLookingForParking : Form
    {

        public frmLookingForParking()
        {

            InitializeComponent();

            cmbDest.DataSource = MyDB.streets.GetList();
            dtpFromStatic.Format = DateTimePickerFormat.Custom;
            dtpFromStatic.CustomFormat = "HH:mm";
            dtpFromStatic.ShowUpDown = true;
            dtpToStatic.Format = DateTimePickerFormat.Custom;
            dtpToStatic.CustomFormat = "HH:mm";
            dtpToStatic.ShowUpDown = true;
            dtpFromOnce.Format = DateTimePickerFormat.Custom;
            dtpFromOnce.CustomFormat = "HH:mm";
            dtpFromOnce.ShowUpDown = true;
            dtpToOnce.Format = DateTimePickerFormat.Custom;
            dtpToOnce.CustomFormat = "HH:mm";
            dtpToOnce.ShowUpDown = true;

        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            grpStatic.Visible = true;
            grpOnce.Visible = false;
        }

        private void btnOnce_Click(object sender, EventArgs e)
        {
            grpOnce.Visible = true;
            grpStatic.Visible = false;
        }
        private void btnSearchStaticParking_Click(object sender, EventArgs e)
        {
            flpSelectedParking.Controls.Clear();
            if (cmbDest.SelectedItem == null)
            {
                //שגיאה - אין יעד
            }
            List<Parking> park;
            if (chekStreet.Checked)
            {
                park = MyDB.parking.GetList().Where(x => x.StreetHelp == cmbDest.SelectedItem).ToList();
            }
            else
            {

                int area = ((Street)(cmbDest.SelectedItem)).AreaCode;
                park = MyDB.parking.GetList().Where(x => x.Area == area).ToList();
            }
            DateTime fromHour;
            DateTime toHour;
            //חיפוש חניה קבועה
            fromHour = dtpFromStatic.Value;
            toHour = dtpToStatic.Value;
            fromHour = fromHour.AddSeconds(-(fromHour.Second));
            toHour = toHour.AddSeconds(-(toHour.Second));
            string day = cmbDay.SelectedItem.ToString();

            //חיפוש חניה לפי המשתנים
            park = park.Where(x => x.IsAvailable(day, fromHour, toHour)).ToList();
            if (park.Count == 0)
                MessageBox.Show(".מצטערים, לא נמצאו חניות לפי חיפוש זה");
            //מילוי הפנאל לפי כל הסינונים
            else
            {
                
                foreach (var item in park)
                {
                    UCSelectedParking parking = new UCSelectedParking(item);
                    parking.keepDetails(day, fromHour, toHour);
                    flpSelectedParking.Controls.Add(parking);
                }
            }

        }

        private void btnSearchOnceParking_Click_1(object sender, EventArgs e)
        {
            flpSelectedParking.Controls.Clear();
            
            if (cmbDest.SelectedItem == null)
            {
                //שגיאה - אין יעד
            }
            List<Parking> park;
            if (chekStreet.Checked)
            {
                park = MyDB.parking.GetList().Where(x => x.StreetHelp == cmbDest.SelectedItem).ToList();
            }
            else
            {

                int area = ((Street)(cmbDest.SelectedItem)).AreaCode;
                park = MyDB.parking.GetList().Where(x => x.Area == area).ToList();
            }
            DateTime fromHour;
            DateTime toHour;
            fromHour = dtpFromOnce.Value.ClearSeconds();
            toHour = dtpToOnce.Value.ClearSeconds();


            DateTime date = dtpDate.Value;


            //חיפוש חניה חד פעמית
            park = park.Where(x => x.IsAvailable(date, fromHour, toHour)).ToList();
            if (park.Count==0)
                MessageBox.Show(".מצטערים, לא נמצאו חניות לפי חיפוש זה");
            else
            {
                foreach (var item in park)
                {
                    UCSelectedParking parking = new UCSelectedParking(item);
                    parking.keepDetails(date, fromHour, toHour);
                    flpSelectedParking.Controls.Add(parking);

                }
            }

        }
    }
}
