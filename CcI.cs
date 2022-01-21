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
    public partial class CcI : Form
    {
        public CcI()
        {
            InitializeComponent();
            VisaB.BackgroundImage = Properties.Resources.visa;
            PaypalΒ.BackgroundImage = Properties.Resources.paypal;
            AmexB.BackgroundImage = Properties.Resources.amex;
            SaveB.BackgroundImage = Properties.Resources.shopping_list;
            lblCCV.Visible = false; lblNumber.Visible = false; lblName.Visible = false; lblDate.Visible = false;
            tbCCV.Visible = false; tbNum.Visible = false; tbName.Visible = false; tbDate.Visible = false;
            tbCCV.MaxLength = 4; tbDate.MaxLength = 10; tbName.MaxLength = 30; tbNum.MaxLength = 16;
        }

        private void VisaB_Click(object sender, EventArgs e)
        {
            if (lblCCV.Visible == false)
            {
                lblCCV.Visible = true; lblNumber.Visible = true; lblName.Visible = true; lblDate.Visible = true;
                tbCCV.Visible = true; tbNum.Visible = true; tbName.Visible = true; tbDate.Visible = true;
            }
            else
            {
                lblCCV.Visible = false; lblNumber.Visible = false; lblName.Visible = false; lblDate.Visible = false;
                tbCCV.Visible = false; tbNum.Visible = false; tbName.Visible = false; tbDate.Visible = false;
            }
        }
        private void PaypalB_Click(object sender, EventArgs e)
        {
            if (lblCCV.Visible == false)
            {
                lblCCV.Visible = true; lblNumber.Visible = true; lblName.Visible = true; lblDate.Visible = true;
                tbCCV.Visible = true; tbNum.Visible = true; tbName.Visible = true; tbDate.Visible = true;
                lblDate.Text = "Username"; tbDate.MaxLength = 30; tbDate.PlaceholderText = "Username";
                lblCCV.Text = "Password"; tbCCV.PasswordChar = '*'; tbCCV.PlaceholderText = "Password"; tbCCV.MaxLength = 30;
            }
            else
            {
                lblCCV.Visible = false; lblNumber.Visible = false; lblName.Visible = false; lblDate.Visible = false;
                tbCCV.Visible = false; tbNum.Visible = false; tbName.Visible = false; tbDate.Visible = false;
                lblDate.Text = "Ημερομηνία Λήξεως"; tbDate.MaxLength = 10; tbDate.PlaceholderText = "HH/MM/EEEE";
                lblCCV.Text = "CCV"; tbCCV.PasswordChar = '*'; tbCCV.PlaceholderText = "3 ή 4 Ψηφία"; tbCCV.MaxLength = 4;
            }

        }

        private void AmexB_Click(object sender, EventArgs e)
        {
            if (lblCCV.Visible == false)
            {
                lblCCV.Visible = true; lblNumber.Visible = true; lblName.Visible = true; lblDate.Visible = true;
                tbCCV.Visible = true; tbNum.Visible = true; tbName.Visible = true; tbDate.Visible = true;
            }
            else
            {
                lblCCV.Visible = false; lblNumber.Visible = false; lblName.Visible = false; lblDate.Visible = false;
                tbCCV.Visible = false; tbNum.Visible = false; tbName.Visible = false; tbDate.Visible = false;
            }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            string message = "Τα στοιχεία σας είναι: " + string.Concat(tbName.Text," ", tbNum.Text, " ", tbDate.Text, " ", tbCCV.Text);
            string title = "Συμφωνείτε στα στοιχεία σας;";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result==DialogResult.OK)
            {
                this.Close();
                MessageBox.Show("Ευχαριστούμε που μας επιλέξατε!");
                string message2 = "Η παραγγελία σας ετοιμάζεται";
                string title2 = "Έξοδος;";
                MessageBoxButtons btns = MessageBoxButtons.OKCancel;
                DialogResult result2 = MessageBox.Show(message2, title2, btns);
                if (result2 == DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    Refresh();
                }

            }
            else
            {
                tbCCV.Text = null;
                tbDate.Text = null;
                tbName.Text = null;
                tbNum.Text = null;
                this.Close();
            }
        }
        private void tbName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Παρακαλώ εισάγεται το Ονοματεπώνυμό σας,\nόπως αυτό παρουσιάζεται πάνω στην κάρτα σας.",tbName);
        }

        private void tbNum_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Παρακαλώ εισάγετε τον 16-ψήφιο αριθμό\nπου βρίσκεται στο μπροστινό μέρος της κάρτας σας.", tbNum);
        }

        private void tbDate_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Η μορφή της ημερομηνίας είναι ΗΗ/ΜΜ/ΕΕΕΕ!", tbDate);
        }

        private void tbCCV_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Παρακαλώ εισάγετε τον 3-ψηφιο ή 4-ψήφιο αριθμό\nπου βρίσκεται στο πίσω μέρος της κάρτας σας", tbCCV);
        }
    }
}
