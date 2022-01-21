using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class SmartHome : Form
    {
        public SmartHome()
        {
            InitializeComponent();
            button2.BackgroundImage = Properties.Resources.home_page;
        }

        private void φΩΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseLights frm1 = new();
            this.Hide();
            frm1.ShowDialog();
        }

        private void θΕΡΜΟΣΤΑΤΗΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thermostat frm2 = new Thermostat();
            this.Hide();
            frm2.Show();
        }

        private void κΑΜΕΡΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cameras frm3 = new Cameras();
            this.Hide();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeSlide bs = new HomeSlide();
            this.Hide();
            bs.Show();
        }
    }
}
