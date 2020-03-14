using DecoratorPattern;
using NUnit.Framework;
using NUnitTestProject1;

namespace Tests
{
    [TestFixture]
    public class WhenCreatingDarkRoast
    {
        [Test]
        public void DescriptionIsInitialized()
        {
            DarkRoast darkRoast = new DarkRoastBuilder().Build();

            Assert.That(darkRoast.Description, Is.EqualTo("The Best Dark Roast"));
        }

        [TestCase(true, false, false, false, 2.5)]
        [TestCase(false, true, false, false, 2.75)]
        [TestCase(false, false, true, false, 3)]
        [TestCase(false, false, false, true, 2.57)]
        public void CostIsComputedWithSingleTopping(bool hasMilk, bool hasMocha, bool hasSoy, bool hasWhip, double expectedCost)
        {
            DarkRoast darkRoast = new DarkRoastBuilder()
                .WithHasMilk(hasMilk)
                .WithHasMocha(hasMocha)
                .WithHasSoy(hasSoy)
                .WithHasWhip(hasWhip)
                .Build();

            Assert.That(darkRoast.Cost(), Is.EqualTo(expectedCost));
        }

        [TestCase(true, true, false, false, 3.25)]
        public void CostIsComputedWithMultipleTopping(bool hasMilk, bool hasMocha, bool hasSoy, bool hasWhip, double expectedCost)
        {
            DarkRoast darkRoast = new DarkRoastBuilder()
                .WithHasMilk(hasMilk)
                .WithHasMocha(hasMocha)
                .WithHasSoy(hasSoy)
                .WithHasWhip(hasWhip)
                .Build();

            Assert.That(darkRoast.Cost(), Is.EqualTo(expectedCost));
        }
    }
}