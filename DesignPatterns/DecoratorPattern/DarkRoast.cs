namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        private const double Price = 2;
        public override string Description => "The Best Dark Roast";

        public override double Cost()
        {
            return Price;
        }
    }
}