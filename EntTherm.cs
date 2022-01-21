using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class EntTherm : Form
    {
        public EntTherm()
        {
            InitializeComponent();
            button23.Visible = false;
            button23.BackgroundImage = Properties.Resources.right;
            timer1.Enabled = false;
        }
        static float NextFloat(float min, float max)
        {
            System.Random random = new();
            double val = (random.NextDouble() * (max - min) + min);
            return (float)(decimal)val;
        }
        private void EntTherm_Load(object sender, EventArgs e)
        {
            List<float> degrees = new();
            degrees.Add(NextFloat(36f, 39f));
            
            foreach (float i in degrees)
            {
                if (i is >= 36f and <= 36.6f)
                {
                    label1.Text = "Η θερμοκρασία σου είναι\n"+ String.Join(" ", ((float)i).ToString()) + " \u00B0 C";
                    label.Text = "Μπορείτε να περάσετε!";
                    label.BackColor = Color.SeaGreen;
                    button23.Visible = true;
                    PcrB.Visible = false;
                }
                else if (i is > 36.6f and <= 37.2f)
                {
                    label1.Text = "Η θερμοκρασία σου είναι\n" + String.Join(" ", ((float)i).ToString()) + " \u00B0 C";
                    label.Text = "Παρακαλώ Ξεκουραστείτε για 5' και Ξαναμετρηθείτε!";
                    label.BackColor = Color.AliceBlue;
                    button23.Visible = false;
                    PcrB.Visible = false;
                }
                else if (i is > 37.2f and <= 38f)
                {
                    label1.Text = "Η θερμοκρασία σου είναι\n" + String.Join(" ", ((float)i).ToString()) + " \u00B0 C";
                    label.Text = "Δεν μπορείτε να περάσετε και προτείνεται προσοχή!";
                    label.BackColor = Color.Yellow;
                    button23.Visible = false;
                    PcrB.Visible = false;
                }
                else if (i is > 38f)
                {
                    label1.Text = "Η θερμοκρασία σου είναι\n" + String.Join(" ", ((float)i).ToString()) + " \u00B0 C";
                    label.Text = "Χρειάζεται να υποστείτε σε Μοριακό Έλεγχο με τη μέθοδο PCR";
                    label.BackColor = Color.Red;
                    button23.Visible = false;
                    PcrB.Visible = true;
                }
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            HomeSlide hsl = new();
            hsl.Show();
            this.Hide();
        }
        public string GoogleMapsRoute(string dest, string municipal)
        {
            string GmapsQ = "https://www.google.com/maps/dir/?api=1&destination=" + dest + "+" + municipal + "&travelmode=transit/";
            Process.Start("cmd", "/c start " + GmapsQ);
            return GmapsQ;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            GoogleMapsRoute("pharmacy", "Athens");
        }
    }
}
