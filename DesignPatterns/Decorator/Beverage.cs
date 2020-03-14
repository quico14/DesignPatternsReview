namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description { get; set; }
        private bool Milk { get; set; }
        private bool Soy { get; set; }
        private bool Mocha { get; set; }
        private bool Whip { get; set; }

        private const double MilkPrice = 0.5;
        private const double SoyPrice = 1;
        private const double MochaPrice = 0.75;
        private const double WhipPrice = 0.57;

        protected Beverage(string description, bool milk, bool soy, bool mocha, bool whip)
        {
            Description = description;
            Milk = milk;
            Soy = soy;
            Mocha = mocha;
            Whip = whip;
        }

        protected Beverage(bool milk, bool soy, bool mocha, bool whip)
        {
            Milk = milk;
            Soy = soy;
            Mocha = mocha;
            Whip = whip;
        }

        public Beverage()
        {
            
        }

        public double Cost()
        {
            double cost = 0;

            if (Milk)
                cost += MilkPrice;
            if (Soy)
                cost += SoyPrice;
            if (Mocha)
                cost += MochaPrice;
            if (Whip)
                cost += WhipPrice;

            return cost;
        }
    }
}