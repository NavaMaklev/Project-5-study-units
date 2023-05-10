using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedParking.BLL;

namespace SharedParking.GUI
{
    public partial class UCpermanetAvailability : UserControl
    {
        private PermanentAvailability permanent;
        private int code;
        public UCpermanetAvailability()
        {
            InitializeComponent();
        }
        public UCpermanetAvailability(PermanentAvailability permanent)
        {
            InitializeComponent();
            this.permanent = permanent;
            fillFields();
            this.code = permanent.Code;
        }
        private void fillFields()
        {
            lblDay.Text = permanent.DayInWeek;
            lblFromHour.Text = (permanent.FromAnHour).ToShortTimeString();
            lblToHour.Text = permanent.ToAnHour.ToShortTimeString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PermanentAvailability toDelete = MyDB.permanentAvailability.GetList().FirstOrDefault(x => x.Code == code);
            DialogResult result = MessageBox.Show("הינך עומד למחוק זמינות " , "מחיקת זמינות", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //מחיקה
               MyDB.permanentAvailability.DeleteItem(toDelete);
                MyDB.permanentAvailability.SaveChanges();
                this.Visible = false;
            }
        }
    }
}
