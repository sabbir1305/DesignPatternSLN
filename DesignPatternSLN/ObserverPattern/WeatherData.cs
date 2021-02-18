using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private IList<IObserver> observers;
        private double temparature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update();
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMEasurements(double temp , double humid , double press)
        {
            temparature = temp;
            humidity = humid;
            pressure = press;
            MeasurementsChanged();
        }
        public double GetTemperature()
        {
            return temparature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetPressure()
        {
            return pressure;
        }
    }
}
