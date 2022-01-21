using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
            CoffeB.BackgroundImage = Properties.Resources.coffee;
            ShomeB.BackgroundImage = Properties.Resources.smart_home;
            SmsB.BackgroundImage = Properties.Resources.email;
            ExitB.BackgroundImage = Properties.Resources.emergency_exit;
        }

        private void CoffeB_Click(object sender, EventArgs e)
        {
            Coffee_Dog cfd = new();
            this.Hide();
            cfd.Show();
        }

        private void ShomeB_Click(object sender, EventArgs e)
        {
            EntTherm et = new();
            this.Hide();
            et.Show();
        }

        private void SmsB_Click(object sender, EventArgs e)
        {
            QplanSMS qplan = new();
            this.Hide();
            qplan.Show();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SocialServB_Click(object sender, EventArgs e)
        {
            EldHelp eld = new();
            Hide();
            eld.Show();
        }

        private void HelpB_Click(object sender, EventArgs e)
        {
            using var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"D:\MSc Information\C_Sharp\Person_Machine\Resources\Person_Machine - Helper.chm")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
