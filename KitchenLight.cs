using System;
using System.Drawing;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class KitchenLight : Form
    {
        public KitchenLight()
        {
            InitializeComponent();
            HomeB.BackgroundImage = Properties.Resources.home_page;
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }
        private void KitchenLight_Load(object sender, EventArgs e)
        {
            SwitchB.Text = "OFF";
            SwitchB.BackgroundImage = Properties.Resources.switchOff;
            panel1.Visible = true;
        }

        private void SwitchB_Click(object sender, EventArgs e)
        {
            if (SwitchB.Text == "OFF")
            {
                SwitchB.BackgroundImage = Properties.Resources.switchOn;
                panel1.Visible = false;
                SwitchB.Text = "ON";

            }
            else
            {
                SwitchB.BackgroundImage = Properties.Resources.switchOff;
                SwitchB.Text = "OFF";
                panel1.Visible = true;
            }
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            BaseLights bl = new();
            Hide();
            bl.ShowDialog();
        }

    }
}
