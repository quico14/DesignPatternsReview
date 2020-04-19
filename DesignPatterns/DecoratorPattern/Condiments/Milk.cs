namespace DecoratorPattern.Condiments
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage beverage;
        private const double Price = 0.75;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", milk";

        public override double Cost()
        {
            return beverage.Cost() + Price;
        }
    }
}