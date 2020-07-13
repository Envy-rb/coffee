namespace kolyaKurs.entity
{
    class Ingredient : IngredientInterface
    {
        private string name;
        private double price;

        public Ingredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name => name;

        public double Price => price;

        public string IngredientType => "Ингредиент";

        public override string ToString()
        {
            return IngredientType + ": " + name;
        }
    }
}