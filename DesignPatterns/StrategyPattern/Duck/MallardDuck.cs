namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quack = new NormalQuack();
            this.fly = new NormalFly();
        }
        public override string Display()
        {
            return "I'm a real mallard duck :'(";
        }
    }
}