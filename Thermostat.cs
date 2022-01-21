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
    public partial class Thermostat : Form
    {
        public Thermostat()
        {
            InitializeComponent();
            if (ColdRB.Checked == true)
            {
                ThermSet.BackColor = Color.PowderBlue;
            }
            else if (HotRB.Checked == true)
            {
                ThermSet.BackColor = Color.Tomato;
            }
            TempVs.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            TempVs.Text = Text.ToString() + "°C";

        }

        private void ColdRB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.HotRB.Checked)
            {
                ColdRB.Checked = false;
                ThermSet.BackColor = Color.Tomato;
            }
        }

        private void HotRB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ColdRB.Checked)
            {
                HotRB.Checked = false;
                ThermSet.BackColor = Color.PowderBlue;
            }
        }

        private void ThermSet_Scroll(object sender, EventArgs e)
        {
            TempVs.Text = "" + ThermSet.Value + "°C";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmartHome frm4 = new SmartHome();
            frm4.Show();
            this.Close();
        }
    }
}
