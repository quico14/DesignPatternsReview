namespace StrategyPattern.Behavior.FlyBehavior
{
    public class FlyRocketPowered : StrategyPattern.FlyBehavior
    {
        public string Fly()
        {
            return "I'm flying with a rocket!";
        }
    }
}