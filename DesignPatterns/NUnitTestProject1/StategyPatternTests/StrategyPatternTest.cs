using StrategyPattern;
using NUnit.Framework;
using NUnitTestProject1;
using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Tests
{
    [TestFixture]
    public class WhenCreatingMallardDuck
    {
        [Test]
        public void DisplayIsInitialized()
        {
            Duck mallardDuck = new MallardDuck();

            Assert.That(mallardDuck.Display(), Is.EqualTo("I'm a real mallard duck :'("));
        }

        [Test]
        public void QuackBehaviorIsUsed()
        {
            Duck mallardDuck = new MallardDuck();

            Assert.That(mallardDuck.PerformQuack(), Is.EqualTo("Quack!"));
        }
    }

    [TestFixture]
    public class WhenSettingBehavior
    {
        [Test]
        public void QuackBehaviorIsSet()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.setQuackBehavior(new MuteQuack());

            Assert.That(mallardDuck.PerformQuack(), Is.EqualTo(""));
        }

        [Test]
        public void FlyBehaviorIsSet()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.setFlyBehavior(new NoFly());

            Assert.That(mallardDuck.PerformFly(), Is.EqualTo("No fly :("));
        }
    }

    [TestFixture]
    public class WhenCreatingQuackBehavior
    {
        [Test]
        public void NormalQuackBehaviorIsUsed()
        {
            QuackBehavior behavior = new NormalQuack();

            Assert.That(behavior.Quack(), Is.EqualTo("Quack!"));
        }
        [Test]
        public void MuteQuackBehaviorIsUsed()
        {
            QuackBehavior behavior = new MuteQuack();

            Assert.That(behavior.Quack(), Is.EqualTo(""));
        }
        [Test]
        public void SqueakQuackBehaviorIsUsed()
        {
            QuackBehavior behavior = new SqueakQuack();

            Assert.That(behavior.Quack(), Is.EqualTo("Squeak!"));
        }
    }

    [TestFixture]
    public class WhenCreatingFlyBehavior
    {
        [Test]
        public void NormalFlyBehaviorIsUsed()
        {
            FlyBehavior behavior = new NormalFly();

            Assert.That(behavior.Fly(), Is.EqualTo("Flying!"));
        }
        [Test]
        public void NoFlyBehaviorIsUsed()
        {
            FlyBehavior behavior = new NoFly();

            Assert.That(behavior.Fly(), Is.EqualTo("No fly :("));
        }
    }
}