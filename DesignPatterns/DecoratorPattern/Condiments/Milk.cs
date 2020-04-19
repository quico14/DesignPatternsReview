namespace DecoratorPattern.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        private const double Price = 0.75;

        public Milk(Beverage beverage)
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
            return Beverage.GetDescription() + ", milk";
        }
    }
}