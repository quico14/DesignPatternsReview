namespace ObserverPattern.Displays
{
    public class DisplayTwo : IDisplay, IObserver
    {
        public WeatherData WeatherData { get; set; }
        public int Humidity { get; set; }


        public DisplayTwo(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Update(IObservable observable)
        {
            var weatherData = (WeatherData)observable;
            Humidity = weatherData.Humidity;
        }

        public string Display()
        {
            return $"Display two: {this.Humidity}";
        }
    }
}