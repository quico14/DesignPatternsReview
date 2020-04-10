namespace ObserverPattern.Displays
{
    public class DisplayThree : IDisplay, IObserver
    {
        public int Pressure { get; set; }
        public WeatherData WeatherData { get; set; }


        public DisplayThree(WeatherData weatherData)
        {
            WeatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Update(IObservable observable)
        {
            var weatherData = (WeatherData)observable;
            Pressure = weatherData.Pressure;
        }

        public string Display()
        {
            return $"Display three: {this.Pressure}";
        }
    }
}