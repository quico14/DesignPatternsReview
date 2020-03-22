﻿namespace StrategyPattern
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