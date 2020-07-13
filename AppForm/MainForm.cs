using kolyaKurs.Service;
using kolyaKurs.entity;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using kolyaKurs.AppForm;
using System.Data.OleDb;

namespace kolyaKurs
{
    public partial class MainForm : Form
    {
        IngredientsService ingredientsService = new IngredientsService();
        CoffeeService coffeeService = new CoffeeService();
        CashboxService cashbox = new CashboxService();

        public MainForm()
        {
            InitializeComponent();
            CoffeeList.DataSource = coffeeService.CoffeeCups;
            CoffeeList.DisplayMember = "Label";


            IngredientList.DataSource = ingredientsService.Ingredients;
            IngredientList.DisplayMember = "ToString()";

        }

        void Form1_Load(object sender, EventArgs e)
        {
        }

        private CoffeeCup getSelectedCoffeeCup()
        {
            return (CoffeeCup)CoffeeList.SelectedItem;
        }

        private IngredientInterface getSelectedIngredient()
        {
            return (IngredientInterface)IngredientList.SelectedItem;
        }

        private void CoffeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text;
            if (getSelectedCoffeeCup() != null)
            {
                text = getSelectedCoffeeCup().Description;
            }
            else
            {
                text = "Чашечка кофеечка не выбрана";
            }

            CoffeeDescription.Text = text;
        }

        private void RemoveCoffeeButton_Click(object sender, EventArgs e)
        {
            coffeeService.removeCoffeeCup(getSelectedCoffeeCup());
        }

        private void RemoveIngredientButton_Click(object sender, EventArgs e)
        {
            ingredientsService.removeIngredient(getSelectedIngredient());
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            var form = new IngredientForm();
            IngredientInterface ingredientInterface = null;
            DialogResult dr = form.ShowDialog(this);
            if (dr == DialogResult.OK)
                ingredientInterface = form.GetIngredient();
            if (ingredientInterface.Name.Length > 0 && ingredientInterface.Price > 0)
                ingredientsService.addIngredient(ingredientInterface);
            form.Close();
        }

        private void MakeCoffeeButton_Click(object sender, EventArgs e)
        {
            var form = new CoffeeForm(ref ingredientsService.Ingredients);

            DialogResult dr = form.ShowDialog(this);
            coffeeService.addCoffeeCup(form.GetCoffee());
            form.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((CoffeeCup)CoffeeList.SelectedItem).addIngredient((IngredientInterface)IngredientList.SelectedItem);
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            double tax = 20;
            //var form = new CashboxForm()
            cashbox.addCash(getSelectedCoffeeCup().Label, getSelectedCoffeeCup().getPrice(), tax);
            Cash.Text = cashbox.Cash.ToString();
            coffeeService.removeCoffeeCup(getSelectedCoffeeCup());
        }

        private void DraftList_Click(object sender, EventArgs e)
        {
            var form = new DraftListForm();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new FAQForm();
            form.Show(this);
            Help.ShowHelp(this, @"Help.chm");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}