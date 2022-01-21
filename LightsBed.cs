using System;
using System.Drawing;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class LightsBed : Form
    {
        public LightsBed()
        {
            InitializeComponent();
            HomeB.BackgroundImage = Properties.Resources.home_page;
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }
        private void Test_Load(object sender, EventArgs e)
        {
            button1.Text = "OFF";
            button1.BackgroundImage = Properties.Resources.switchOff;
            panel1.Visible = true; 
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BaseLights bl = new();
            Hide();
            bl.ShowDialog();
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
                button1.Text = "OFF";
                panel1.Visible = true;
            }
        }
/*
        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "OFF")
            {
                button2.BackgroundImage = Properties.Resources.switchOn;
                panel2.Visible = false;
                button2.Text = "ON";

            }
            else
            {
                button2.BackgroundImage = Properties.Resources.switchOff;
                button2.Text = "OFF";
                panel2.Visible = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "OFF")
            {
                button3.BackgroundImage = Properties.Resources.switchOn;
                panel3.Visible = false;
                button3.Text = "ON";

            }
            else
            {
                button3.BackgroundImage = Properties.Resources.switchOff;
                button3.Text = "OFF";
                panel3.Visible = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "OFF")
            {
                button4.BackgroundImage = Properties.Resources.switchOn;
                panel4.Visible = false;
                button4.Text = "ON";

            }
            else
            {
                button4.BackgroundImage = Properties.Resources.switchOff;
                button4.Text = "OFF";
                panel4.Visible = true;
            }
        }*/

    }
}
