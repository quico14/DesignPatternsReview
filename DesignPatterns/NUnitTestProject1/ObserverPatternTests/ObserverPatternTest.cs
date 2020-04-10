using NUnit.Framework;
using ObserverPattern;
using ObserverPattern.Displays;

namespace Tests.ObserverPatternTests
{
    [TestFixture]
    public class WhenCreatingWeatherData
    {
        [Test]
        public void WeatherDataIsInitialized()
        {
            WeatherData weatherData = new WeatherData();

            Assert.That(weatherData.Temperature, Is.EqualTo(0));
            Assert.That(weatherData.Humidity, Is.EqualTo(0));
            Assert.That(weatherData.Pressure, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class WhenMeasurementsChanged
    {
        [Test]
        public void AllDisplaysAreUpdated()
        {
            var weatherData = new WeatherData();
            var displayOne = new DisplayOne(weatherData);
            var displayTwo = new DisplayTwo(weatherData);
            var displayThree = new DisplayThree(weatherData);

            weatherData.Temperature = 2;
            weatherData.Humidity = 3;
            weatherData.Pressure = 4;

            weatherData.MeasurementsChanged();

            Assert.That(displayOne.Display(), Is.EqualTo($"Display one: " +
                                                         $"{weatherData.Temperature}"));
            Assert.That(displayTwo.Display(), Is.EqualTo($"Display two: " +
                                                         $"{weatherData.Humidity}"));
            Assert.That(displayThree.Display(), Is.EqualTo($"Display three: " +
                                                         $"{weatherData.Pressure}"));
        }
    }

    [TestFixture]
    public class WhenCreatingDisplayOne
    {
        [Test]
        public void DisplayOneIsInitialized()
        {
            var weatherData = new WeatherData();
            var displayOne = new DisplayOne(weatherData);

            Assert.That(displayOne.Temperature, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class WhenCreatingDisplayTwo
    {
        [Test]
        public void DisplayTwoIsInitialized()
        {
            var weatherData = new WeatherData();
            var displayTwo = new DisplayTwo(weatherData);

            Assert.That(displayTwo.Humidity, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class WhenCreatingDisplayThree
    {
        [Test]
        public void DisplayThreeIsInitialized()
        {
            var weatherData = new WeatherData();
            var displayThree = new DisplayThree(weatherData);

            Assert.That(displayThree.Pressure, Is.EqualTo(0));
        }
    }
}
