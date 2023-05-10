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
    public partial class ghghg : Form
    {
        public ghghg()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\pic\\" + "logo.png");
        }

        private void ghghg_Load(object sender, EventArgs e)
        {

        }
    }
}
