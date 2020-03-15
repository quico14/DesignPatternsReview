using DecoratorPattern;

namespace NUnitTestProject1
{
    public class DarkRoastBuilder
    {
        private bool hasMilk;
        private bool hasSoy;
        private bool hasMocha;
        private bool hasWhip;

        public DarkRoast Build()
        {
            return new DarkRoast(hasMilk, hasSoy, hasMocha, hasWhip);
        }

        public DarkRoastBuilder WithHasMilk(bool hasMilk)
        {
            this.hasMilk = hasMilk;
            return this;
        }

        public DarkRoastBuilder WithHasSoy(bool hasSoy)
        {
            this.hasSoy = hasSoy;
            return this;
        }

        public DarkRoastBuilder WithHasMocha(bool hasMocha)
        {
            this.hasMocha = hasMocha;
            return this;
        }

        public DarkRoastBuilder WithHasWhip(bool hasWhip)
        {
            this.hasWhip = hasWhip;
            return this;
        }
    }
}
