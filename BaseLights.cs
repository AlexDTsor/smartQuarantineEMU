using System;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class BaseLights : Form
    {
        public BaseLights()
        {
            InitializeComponent();
            KitchenB.BackgroundImage = Properties.Resources.kitchen_hood;
            LivingRoomB.BackgroundImage = Properties.Resources.sofa;
            BedroomB.BackgroundImage = Properties.Resources.bed;
            HomeB.BackgroundImage = Properties.Resources.home_page;
            FrontYardB.BackgroundImage = Properties.Resources.yard;
        }

        private void BedroomB_Click(object sender, EventArgs e)
        {
            LightsBed lb = new();
            Hide();
            lb.ShowDialog();
        }

        private void LivingRoomB_Click(object sender, EventArgs e)
        {
            LivingRoomLight lrl = new();
            Hide();
            lrl.ShowDialog();
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            SmartHome sh = new();
            Hide();
            sh.ShowDialog();
        }

        private void KitchenB_Click(object sender, EventArgs e)
        {
            KitchenLight kl = new();
            Hide();
            kl.ShowDialog();
        }

        private void FrontYardB_Click(object sender, EventArgs e)
        {
            YardLights yl = new();
            Hide();
            yl.ShowDialog();
        }
    }
}
