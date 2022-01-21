using System;
using System.Drawing;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class LivingRoomLight : Form
    {
        public LivingRoomLight()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            
        }

        private void Lights_Load(object sender, EventArgs e)
        {
            button1.Text = "OFF"; //initiallize button
            button1.BackgroundImage = Properties.Resources.switchOff;
            panel1.Visible = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "OFF")
            {
                button1.BackgroundImage = Properties.Resources.switchOn;
                panel1.Visible = false;
                button1.Text = "ON";
                
            }
            else
            {
                button1.BackgroundImage = Properties.Resources.switchOff;
                panel1.Visible = true;
                button1.Text = "OFF";
                panel1.Visible = true;
            }
 
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            BaseLights bsL = new();
            bsL.Show();
            this.Hide();
        }
    }
}
