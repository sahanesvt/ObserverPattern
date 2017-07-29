using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.9f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            display();
        }

        public void display()
        {
            string forecast="";

            if (currentPressure > lastPressure)
            {
                forecast = "Improving weather on the way!";
            }

            else if(currentPressure == lastPressure)
            {
                forecast = "More of the same.";
            }

            else if (currentPressure < lastPressure)
            {
                forecast = "Watch out for cooler, rainy weather.";
            }

            Console.WriteLine("Forecast: " + forecast);
        }

        public void unsubscribe(ISubject weatherData)
        {
            weatherData.removeObserver(this);
        }
    }
}
