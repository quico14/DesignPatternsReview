using StrategyPattern.Behavior.QuackBehavior;

namespace StrategyPattern.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.quackBehavior = new NormalQuack();
            this.flyBehavior = new NoFly();
        }
        public override string Display()
        {
            return "I'm model duck :'(";
        }
    }
}