namespace StrategyPattern
{
    public abstract class Duck
    {
        protected QuackBehavior quack;
        protected FlyBehavior fly;
        public abstract string Display();
        public string PerformQuack()
        {
            return quack.Quack();
        }
        public string PerformFly()
        {
            return fly.Fly();
        }
    }
}