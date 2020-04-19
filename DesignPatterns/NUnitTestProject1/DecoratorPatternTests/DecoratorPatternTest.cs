using DecoratorPattern;
using DecoratorPattern.Condiments;
using NUnit.Framework;

namespace Tests.DecoratorPatternTests
{
    [TestFixture]
    public class WhenCreatingDarkRoast
    {
        [Test]
        public void DescriptionIsInitialized()
        {
            DarkRoast darkRoast = new DarkRoast();

            Assert.That(darkRoast.Description, Is.EqualTo("The Best Dark Roast"));
        }

        [Test]
        public void CostIsComputedWithMocha()
        {
            DarkRoast darkRoast = new DarkRoast();
            CondimentDecorator darkRoastWithMocha = new Mocha(darkRoast);

            Assert.That(darkRoastWithMocha.Cost(), Is.EqualTo(2.5));
        }

        [Test]
        public void CostIsComputedWithDoubleMocha()
        {
            DarkRoast darkRoast = new DarkRoast();
            CondimentDecorator darkRoastWithMocha = new Mocha(darkRoast);
            CondimentDecorator darkRoastWithDoubleMocha = new Mocha(darkRoastWithMocha);

            Assert.That(darkRoastWithDoubleMocha.Cost(), Is.EqualTo(3));
        }

        [Test]
        public void CostIsComputedWithMochaAndEspresso()
        {
            DarkRoast darkRoast = new DarkRoast();
            CondimentDecorator darkRoastWithMocha = new Mocha(darkRoast);
            CondimentDecorator darkRoastWithMochaAndMilk = new Milk(darkRoastWithMocha);

            Assert.That(darkRoastWithMochaAndMilk.Cost(), Is.EqualTo(3.25));
        }

        [Test]
        public void DescriptionWithMochaAndEspresso()
        {
            DarkRoast darkRoast = new DarkRoast();
            CondimentDecorator darkRoastWithMocha = new Mocha(darkRoast);
            CondimentDecorator darkRoastWithMochaAndMilk = new Milk(darkRoastWithMocha);

            Assert.That(darkRoastWithMochaAndMilk.Description, Is.EqualTo("The Best Dark Roast, mocha, milk"));
        }
    }
}