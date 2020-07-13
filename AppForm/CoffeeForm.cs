using kolyaKurs.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kolyaKurs.AppForm
{
    public partial class CoffeeForm : Form
    {
        BindingList<IngredientInterface> ingredients;
        BindingList<IngredientInterface> coffees = new BindingList<IngredientInterface>();
        BindingList<IngredientInterface> otherIngredients = new BindingList<IngredientInterface>();
        CoffeeCup res;

        public CoffeeForm(ref BindingList<IngredientInterface> ingredients)
        {
            InitializeComponent();
            this.ingredients = ingredients;
            foreach (var item in this.ingredients)
            {
                if (item.IngredientType == "Кофе")
                {
                    coffees.Add(item);
                }
                else
                {
                    otherIngredients.Add(item);
                }
            }

            CoffeeBox.DataSource = coffees;
            CoffeeBox.DisplayMember = "Name";

            Ingredients.DataSource = otherIngredients;
            Ingredients.DisplayMember = "Name";
            Ingredients.SelectionMode = SelectionMode.MultiSimple;
        }

        public CoffeeCup GetCoffee()
        {
            return res;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label = LabelBox.Text;
            IngredientInterface coffee = (IngredientInterface)CoffeeBox.SelectedItem;
            BindingList<IngredientInterface> ingredients = new BindingList<IngredientInterface>();
            foreach (var item in Ingredients.SelectedItems)
            {
                ingredients.Add((IngredientInterface)item);
            }
            res = new CoffeeCup(label, coffee, ingredients);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sound.wav");
            player.Play();
            timer1.Enabled = true;
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {

        }

        private void Ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var form = new BoilingForm();
            form.ShowDialog(this);
            Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

        }
    }
}
