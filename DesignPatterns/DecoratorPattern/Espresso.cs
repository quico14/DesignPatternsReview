namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        private const double Price = 3;

        public Espresso()
        {
            Description = "Espresso";
        }

        public override double Cost()
        {
            return Price;
        }
    }
}