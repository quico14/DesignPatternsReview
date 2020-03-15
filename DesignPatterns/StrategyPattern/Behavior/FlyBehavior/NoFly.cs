namespace StrategyPattern
{
    public class NoFly : FlyBehavior
    {
        public string Fly()
        {
            return "No fly :(";
        }
    }
}