using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : IObservable
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public List<IObserver> Observers { get; set; }

        public WeatherData()
        {
            Temperature = 0;
            Humidity = 0;
            Pressure = 0;
            Observers = new List<IObserver>();
        }

        public void MeasurementsChanged()
        {
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void DeleteObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
