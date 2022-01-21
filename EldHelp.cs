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
    public partial class EldHelp : Form
    {
        public EldHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3...2...1...\nΜείνετε ψύχραιμος!\n" +
                "Κλήση βοήθειας μεταδίδεται και κάποιος θα είναι πολύ σύντομα κοντά σας!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Χαιρόμαστε που είστε καλά!\n" +
                "Ραντεβού αύριο πάλι!\n" +
                "Ευχόμαστε να μην αργήσετε!");
            HomeSlide bs = new HomeSlide();
            bs.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
