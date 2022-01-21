using System;
using System.Drawing;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class YardLights : Form
    {
        public YardLights()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            HomeB.BackgroundImage = Properties.Resources.home_page;

        }

        private void YardLights_Load(object sender, EventArgs e)
        {
            SwitchB.Text = "OFF"; //initiallize button
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
                panel1.Visible = true;
                SwitchB.Text = "OFF";
                panel1.Visible = true;
            }
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            BaseLights frm4 = new();
            frm4.Show();
            this.Hide();
        }
    }
}
