namespace ObserverPattern.Displays
{
    public class DisplayOne : IDisplay, IObserver
    {
        public int Temperature { get; set; }

        public WeatherData WeatherData { get; set; }


        public DisplayOne(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Update(IObservable observable)
        {
            var weatherData = (WeatherData)observable;
                Temperature = weatherData.Temperature;
        }

        public string Display()
        {
            return $"Display one: {this.Temperature}";
        }
    }
}
