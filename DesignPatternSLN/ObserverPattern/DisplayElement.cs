using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.ObserverPattern
{
    public interface IDisplayElement
    {
        void Display();
    }

    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private double temparature;
        private double humidity;
        public string displayString;
        private WeatherData weatherData;
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            displayString = $"Current conditions: {temparature} F degress and {humidity}% humidity";
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this.temparature = temp;
            this.humidity = humidity;
           
        }
    }
}
