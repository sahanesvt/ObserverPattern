using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentConditionDisplay = new CurrentConditionDisplay(weatherData);

            weatherData.setMeasurements(93, 60, 20);
            //currentConditionDisplay.unsubscribe(weatherData);
            weatherData.notifyObserver();

            Console.ReadLine();
        }
    }
}
