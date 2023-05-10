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
    public partial class frmEnter : Form
    {
        public frmEnter()
        {
            InitializeComponent();
            List<StaticOrder> orders = MyDB.staticOrders.GetList().FindAll(x => x.Status == 2).ToList();
            foreach (var item in orders)
            {
                if (item.EndDate <= DateTime.Today)
                    updateObj(item);
            }

        }
        private void updateObj(StaticOrder item)
        {
            StaticOrder current = item;
            current.Status = 3;
            MyDB.staticOrders.UpdateItem(current);
            MyDB.staticOrders.SaveChanges();

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }
    }
}
