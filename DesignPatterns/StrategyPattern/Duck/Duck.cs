using StrategyPattern.Behavior.QuackBehavior;

namespace StrategyPattern.Duck
{
    public abstract class Duck
    {
        protected QuackBehavior quackBehavior;
        protected FlyBehavior flyBehavior;

        public abstract string Display();

        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }

        public string PerformFly()
        {
            return flyBehavior.Fly();
        }

        public void setQuackBehavior(QuackBehavior quackBehavior) {
            this.quackBehavior = quackBehavior;
        }

        public void setFlyBehavior(FlyBehavior flyBehavior) {
            this.flyBehavior = flyBehavior;
        }
    }
}