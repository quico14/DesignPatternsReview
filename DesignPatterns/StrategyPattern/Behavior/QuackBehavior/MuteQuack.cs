namespace StrategyPattern
{
    public class MuteQuack : QuackBehavior
    {
        public string Quack()
        {
            return "";
        }
    }
}