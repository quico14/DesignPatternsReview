using StrategyPattern.Behavior.FlyBehavior;
using StrategyPattern.Behavior.QuackBehavior;

namespace StrategyPattern.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new NormalQuack();
            this.flyBehavior = new NormalFly();
        }
        public override string Display()
        {
            return "I'm a real mallard duck :'(";
        }
    }
}