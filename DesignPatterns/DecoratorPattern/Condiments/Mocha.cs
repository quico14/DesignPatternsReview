namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;
        private const double Price = 0.5;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description => beverage.Description + ", mocha";

        public override double Cost()
        {
            return beverage.Cost() + Price;
        }
    }
}