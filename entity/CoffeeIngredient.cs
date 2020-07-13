namespace kolyaKurs.entity
{
    class CoffeeIngredient : IngredientInterface
    {
        private string name;
        private double price;

        public CoffeeIngredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name => name;

        public double Price => price;

        public string IngredientType => "Кофе";

        public override string ToString()
        {
            return IngredientType + ": " + name;
        }
    }
}