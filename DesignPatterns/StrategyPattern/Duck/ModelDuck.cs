namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.quackBehavior = new NormalQuack();
            this.flyBehavior = new NormalFly();
        }
        public override string Display()
        {
            return "I'm model duck :'(";
        }
    }
}