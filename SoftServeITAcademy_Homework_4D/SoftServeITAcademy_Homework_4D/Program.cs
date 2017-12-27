using System;

namespace SoftServeITAcademy_Homework_4D
{
    public class Program
    {
        private static IValidatable _validator;

        public static void Main()
        {
            var manager = new WeatherManager();
            manager.GetRandomWeather(12);

            _validator = new ConsoleInputValidator();

            manager.PrintWeather();

            var pressure = _validator.GetDoubleInput("Enter Pressure: (0-1000)", 0, 1000);
            manager.PrintWeatherWhenPressureLessThan(pressure);

            var avgTemp = manager.AverageTemperatureOfNonWindsDays();
            Console.WriteLine($"Середня температура безвітряних днів = {avgTemp}");

            var precipitationsCount = manager.CalculatePrecipitationsCount();

            Console.WriteLine("Порахувати скiльки днiв падав дощ, снiг, а скiльки було без опадiв");
            Console.WriteLine($"Rain: {precipitationsCount.rain} Snow: {precipitationsCount.snow} WithoutPrecipitation: {precipitationsCount.withoutPrecipitation}");

            Console.WriteLine("Видрукувати прогнози погоди в порядку спадання температур");
            var sortedWeather = manager.SortWeatherTemperatureDecrease();
            manager.PrintWeather(sortedWeather);

            Console.ReadKey();
        }
    }
}
