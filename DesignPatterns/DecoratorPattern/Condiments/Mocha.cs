namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        private const double Price = 0.5;

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
            this.Description = beverage.Description;
        }

        public override double Cost()
        {
            return Beverage.Cost() + Price;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", mocha";
        }
    }
}