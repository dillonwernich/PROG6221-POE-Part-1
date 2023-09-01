namespace PartOne
{
    class Ingredient
    {
        //VARIABLES
        public string name;
        public double quantity;
        public string unit;

        //CONSTRUCTOR
        public Ingredient(string name, double quantity, string unit)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
        }

        internal double originalQuantity;
    }

}
