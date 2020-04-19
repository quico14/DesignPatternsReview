namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public Beverage()
        {
            Description = "Unknown";
        }

        public abstract double Cost();

        public string GetDescription()
        {
            return Description;
        }
    }
}