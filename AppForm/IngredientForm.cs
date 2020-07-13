using kolyaKurs.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace kolyaKurs.AppForm
{
    public partial class IngredientForm : Form
    {
        public IngredientForm()
        {
            InitializeComponent();
        }

        public IngredientInterface GetIngredient()
        {
            IngredientInterface res;
            string name = NameBox.Text;
            double price = 0;
            double.TryParse(PriceBox.Text, out price);
            if (TypeBox.SelectedIndex == 0)
            {
                res = new CoffeeIngredient(name, price);
            }
            else
            {
                res = new Ingredient(name, price);
            }
            return res;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Length > 1)
            {
                Close();
            }
        }
    }
}
