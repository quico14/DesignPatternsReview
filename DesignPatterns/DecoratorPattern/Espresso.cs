namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        private const double Price = 3;

        public override string Description { get; } = "Espresso";

        public override double Cost()
        {
            return Price;
        }
    }
}