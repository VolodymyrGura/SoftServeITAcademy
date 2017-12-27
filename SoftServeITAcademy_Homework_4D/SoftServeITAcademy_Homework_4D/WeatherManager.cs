using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftServeITAcademy_Homework_4D
{
    public class WeatherManager
    {
        private readonly Random _random;
        private List<Weather> _weathers;

        public WeatherManager()
        {
            this._random = new Random();
        }

        public void PrintWeather()
        {
            this.PrintWeather(this._weathers);
        }

        public void PrintWeather(IEnumerable<Weather> weathers)
        {
            Console.WriteLine("температура    атм.тиск    сила вiтру      опади");

            foreach (var w in weathers)
            {
                w.Print();
            }
        }

        public void PrintWeatherWhenPressureLessThan(double pressure)
        {
            Console.WriteLine("Видрукувати погоду в тi днi, коли тиск був нижче введеного числа");

            foreach (var w in this._weathers)
            {
                if (w.Pressure < pressure)
                {
                    w.Print();
                }
            }
        }

        public double AverageTemperatureOfNonWindsDays()
        {
            double temperature;
            try
            {
                temperature = this._weathers.Where(w => w.Wind == 0).Average(x => x.Temperature);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Не було безвітряних днів");
                return 0;
            }

            return temperature;
        }

        public (int rain, int snow, int withoutPrecipitation) CalculatePrecipitationsCount()
        {
            var rain = this._weathers.Count(w => w.Precipitation == Precipitations.Rain);
            var snow = this._weathers.Count(w => w.Precipitation == Precipitations.Snow);
            var without = this._weathers.Count(w => w.Precipitation == Precipitations.WithoutPrecipitation);

            return (rain, snow, without);
        }

        public IEnumerable<Weather> SortWeatherTemperatureDecrease()
        {
            return this._weathers.OrderByDescending(w => w.Temperature);
        }

        public void GetRandomWeather(int days)
        {
            this._weathers = new List<Weather>(days);

            for (var i = 0; i < days; i++)
            {
                this._weathers.Add(new Weather
                {
                    Temperature = this._random.Next(-10, 40),
                    Pressure = this._random.Next(1000),
                    Wind = (Winds)this._random.Next(4),
                    Precipitation = (Precipitations)this._random.Next(3)
                });
            }
        }
    }
}
