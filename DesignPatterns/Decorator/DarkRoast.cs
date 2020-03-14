namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        private const double Price = 2;
        private string description = "The Best Dark Roast";

        public DarkRoast()
        {
            
        }

        public DarkRoast(bool milk, bool soy, bool mocha, bool whip) : base(milk, soy, mocha, whip)
        {
            Description = description;
        }
        public double Cost()
        {
            return base.Cost() + Price;
        }
    }
}