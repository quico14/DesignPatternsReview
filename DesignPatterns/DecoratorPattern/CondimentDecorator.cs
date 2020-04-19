namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}