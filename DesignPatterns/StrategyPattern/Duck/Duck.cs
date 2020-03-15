namespace StrategyPattern
{
    public abstract class Duck
    {
        protected QuackBehavior quack;
        public abstract string Display();
        public string PerformQuack()
        {
            return quack.Quack();
        }
    }
}