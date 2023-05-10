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
    public partial class frmMenger : Form
    {
        public frmMenger()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 9)
            {
                if (textBox1.Text == "325444230")
                {
                    frmManagement management = new frmManagement();
                    management.Show();
                }
                else
                {
                    MessageBox.Show("הקש שנית");
                    textBox1.Clear();
                }
            }
        }
    }
}
