using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource shoppingListBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            setBindings();
        }

        private void setBindings()
        {
            carListBinding.DataSource = store.CarList;
            listBox1.DataSource = carListBinding;
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";

            shoppingListBinding.DataSource = store.ShoppingList;
            listBox2.DataSource = shoppingListBinding;
            listBox2.DisplayMember = "Display";
            listBox2.ValueMember = "Display";
        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            int year = 0;
            decimal price = 0;

            if(int.TryParse(yearTextBox.Text, out year) && decimal.TryParse(priceTextBox.Text, out price))
            {
                Car newCar = new Car(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), decimal.Parse(priceTextBox.Text), colorTextBox.Text);

                store.CarList.Add(newCar);

                carListBinding.ResetBindings(false);

                return;
            }

            MessageBox.Show("Please enter numbers only for year and price!");

        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)listBox1.SelectedItem);

            shoppingListBinding.ResetBindings(false);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();

            totalCostValueLabel.Text = "$" + total.ToString();
        }
    }
}
