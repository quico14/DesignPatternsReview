namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public virtual string Description { get; } = "Unknown";

        public abstract double Cost();
    }
}