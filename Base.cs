using System;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class HomeSlide : Form
    {
        public HomeSlide()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EldHelp eld = new();
            this.Hide();
            eld.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SmartHome frm4 = new();
            this.Hide();
            frm4.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrontPage front = new();
            Close();
            front.Show();
        }

        private void Button3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Επιστροφη στην Βάση", button3);
        }
    }
}
