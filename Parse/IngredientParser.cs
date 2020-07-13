using kolyaKurs.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace kolyaKurs.Parse
{
    static class IngredientParser
    {
        public static IngredientInterface parseIngredient(string Name, string Price, string Type)
        {
            IngredientInterface ingredient = null;
            double price;
            if (Double.TryParse(Price, out price))
            {
                if (Type == "Ингредиент")
                {
                    ingredient = new Ingredient(Name, price);
                }
                else if (Type == "Кофе")
                {
                    ingredient = new CoffeeIngredient(Name, price);
                }
            }
            else
            {
                ingredient = new Ingredient("StockName", 10);
            }

            return ingredient;
        }
    }
}
