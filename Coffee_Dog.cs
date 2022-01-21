using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Person_Machine
{
    public partial class Coffee_Dog : Form
    {
        readonly List<Product> products = new();
        readonly List<Food> products2 = new();
        public Coffee_Dog()
        {
            InitializeComponent();
            dog.BackgroundImage = Properties.Resources.dog;
            button2.BackgroundImage = Properties.Resources.credit_card;
            bPrice.BackgroundImage = Properties.Resources.price_tag;
            button3.BackgroundImage = Properties.Resources.emergency_exit;
            AddProducts();
            AddProduct2(); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrontPage fp = new();
            fp.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string SelectedValues = "Έχετε Επιλέξει:\n" + new String('-', 36) + "\n";
            string SelectedValues2 = null; 
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                SelectedValues += checkedListBox1.CheckedItems[i].ToString() + "\n";
            }
            for (int j = 0; j < checkedListBox2.CheckedItems.Count; j++)
            {
                SelectedValues2 += checkedListBox2.CheckedItems[j].ToString() + "\n";
            }

            label.Text = string.Join("\n", SelectedValues, SelectedValues2);
        }

        public void AddProducts()
        {
            products.Add(new Product { Name = "Americano", Price = 2.00m });
            products.Add(new Product { Name = "Cappuccino", Price = 3.50m });
            products.Add(new Product { Name = "Cold Coffe", Price = 1.50m });
            products.Add(new Product { Name = "Double Espresso", Price = 2.00m });
            products.Add(new Product { Name = "Latte", Price = 3.50m });
            products.Add(new Product { Name = "Lungo", Price = 2.00m });
            products.Add(new Product { Name = "Tea", Price = 1.50m });
            products.Add(new Product { Name = "Tea Latte", Price = 3.00m });
            products.Add(new Product { Name = "Aqua", Price = 0.50m });
            checkedListBox1.DataSource = products;
        }

        public void AddProduct2()
        {
            products2.Add(new Food { Name2 = "RedVelvet Cake", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "Banana Bread", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "BlackForest Cake", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "Cheese Cake", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "Peanutbutter Cake", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "Greek Cake", Price2 = 4.00m });
            products2.Add(new Food { Name2 = "Salty Cake", Price2 = 4.00m });
            checkedListBox2.DataSource = products2;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CcI cci = new();
            cci.Show();
            
        }
    }

}
