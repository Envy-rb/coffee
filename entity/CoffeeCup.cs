using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace kolyaKurs.entity
{
    public class CoffeeCup
    {
        private string label;
        private IngredientInterface coffeeIngredient;
        private BindingList<IngredientInterface> ingredients = new BindingList<IngredientInterface>();
        private string description;

        public CoffeeCup() { }

        public CoffeeCup(string label, IngredientInterface coffeeIngredient)
        {
            this.label = label;
            this.coffeeIngredient = coffeeIngredient;
            makeDescription();
        }

        public CoffeeCup(string label, IngredientInterface coffeeIngredient, BindingList<IngredientInterface> ingredients)
        {
            this.label = label;
            this.coffeeIngredient = coffeeIngredient;
            this.ingredients = ingredients;
            makeDescription();
        }

        public void addIngredient(IngredientInterface ingredient)
        {
            ingredients.Add(ingredient);
            makeDescription();
        }

        public string Label => label;

        public string Description => description;

        public IngredientInterface CoffeeIngredient => coffeeIngredient;
        public BindingList<IngredientInterface> Ingredients => ingredients;

        void makeDescription()
        {
            description = "Сварен из кофе марки " + coffeeIngredient.Name + " с добавлением: ";
            foreach (var ingredient in ingredients)
            {
                description += ingredient.Name;
                if (ingredients.Last() != ingredient)
                {
                    description += ", ";
                }
            }

            description += "\nЦена:" + getPrice();
        }

        public double getPrice()
        {
            double price = coffeeIngredient.Price;
            foreach (var ingredient in ingredients)
                price += ingredient.Price;

            return price;
        }
    }
}