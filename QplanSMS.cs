using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class QplanSMS : Form
    {
        public QplanSMS()
        {
            InitializeComponent();
            SendB.BackgroundImage = Properties.Resources.send;
            /*LinkB.Visible = false;*/
            LinkB.BackgroundImage = Properties.Resources.qr_code;
            ExitB.BackgroundImage = Properties.Resources.exit222;
            ChatB.BackgroundImage = Properties.Resources.chat; 
        }
        public string GoogleMapsRoute(string dest, string municipal)
        {
            string GmapsQ = "https://www.google.com/maps/dir/?api=1&destination=" + dest + "+" + municipal+ "&travelmode=transit/";
            Process.Start("cmd", "/c start " + GmapsQ);
            return GmapsQ;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            GoogleMapsRoute("pharmacy", "Athens");
        }

        private void TextBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Παρακαλώ εισάγεται την Πόλη που βρίσκεστε,\nόπως φαίνεται παρακάτω:\nπ.χ. 'Αθήνα'", TxtCity);
        }

        private void listBox1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.Show("Επιλέξτε το Δύωρο πλαίσιο Μετακίνησης", listBox1);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.Show("Επιλέξτε τον τύπο της Μετακίνησής σας", listBox2);
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
            FrontPage fp = new();
            fp.Show();
        }

        private void TxtName_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Παρακαλώ εισάγεται τo όνομα του Αποστολέα,\nόπως φαίνεται παρακάτω:\nπ.χ. 'ΑΛΕΞΑΝΔΡΟΣ ΤΣΟΡΑΚΛΙΔΗΣ'", TxtName);
        }

        private void ChatB_Click(object sender, EventArgs e)
        {
            string SelectedValues = "Αποστέλλεται μήνυμα στο 13033 από " + TxtName.Text + ", Ώρα: ";
            string SelectedValues2 = null;
            string SelectedValues3 = " από " + TxtCity.Text;
            string SelectedValues4 = " με" + " " ;
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                SelectedValues += listBox1.SelectedItems[i].ToString() + " ";
            }
            for (int j = 0; j < listBox2.SelectedItems.Count; j++)
            {
                SelectedValues2 += " για " + listBox2.SelectedItems[j].ToString() + " ";
            }
            for (int x = 0; x < listBox3.SelectedItems.Count; x++)
            {
                SelectedValues4 += listBox3.SelectedItems[x].ToString();
            }

            label1.Text = string.Join(" , ", SelectedValues, SelectedValues2, SelectedValues3, SelectedValues4);
        }
        private void SendB_Click(object sender, EventArgs e)
        {
            string message = "Είστε Σίγουρος-η;";
            string title = "Αποστολή Μηνύματος";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Η Γενική Γραμματεία Πολιτικής Προστασίας σας εύχεται κάλή τύχη!");
            }
            else
            {
               label1.Text = null;
            }
            string error = "Ώρα: 12:00 - 14:00";
            string error2 = "Ώρα: 16:00 - 18:00";
            for (int i = 0; i < label1.Text.Length; i++)
            {
                if (label1.Text.Contains(error))
                {
                    label1.Text = "Παρακαλώ προσοχή γιατί θα υπάρχει πολυκοσμία εκείνη την ώρα.\nΜήπως να επιλέξετε κάποια άλλη ώρα;";
                }
                else if (label1.Text.Contains(error2))
                {
                    label1.Text = "Παρακαλώ προσοχή γιατί θα υπάρχει πολυκοσμία εκείνη την ώρα.\nΜήπως να επιλέξετε κάποια άλλη ώρα;\n" +
                        "Επισκεφτείτε τους Χάρτες ώστε να σας βοηθήσουν.";
                }
            }
        }

        private void listBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Επιλέξτε το Μέσο Μετακίνησής σας", listBox3);
        }
    }
}
