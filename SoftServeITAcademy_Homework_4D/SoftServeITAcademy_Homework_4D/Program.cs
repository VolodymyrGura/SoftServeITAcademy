using System;

namespace SoftServeITAcademy_Homework_4D
{
    public class Program
    {
     private enum Winds
        {
            Tquiet = 0, Llight, Pmoderate, Sstrong
        }

         private enum Precipitations
        {

            WithoutPrecipitation = 0, Rain, Snow
        }

      public static void Main(string[] args)
        {
            Weather[] weather = new Weather[12];
            int i;

            Random randomTemperature = new Random();
            Random randomPressure = new Random();
            Random random = new Random();
            string[] windss = { "Tquiet", "Llight", "Pmoderate", "Sstrong" };
            string[] precipitations = { "WithoutPrecipitation", "Rain", "Snow" };
            int countTemperature = 0;
            int countWithoutPrecipitation = 0, countRain = 0, countSnow = 0;
            double avgTemperature = 0;

            Console.WriteLine("температура    атм.тиск    сила вiтру      опади");
            for (i = 0; i < 12; i++)
            {
                weather[i] = new Weather();
                weather[i].Temperature = randomTemperature.Next(-10, 40);
                weather[i].Pressure = randomPressure.Next(0, 1000);
                weather[i].Wind = ((Winds)random.Next(0, 4)).ToString();
                weather[i].Precipitation = ((Precipitations)random.Next(0, 3)).ToString();
                weather[i].Print(weather[i].Temperature, weather[i].Pressure, weather[i].Wind, weather[i].Precipitation);
            }

            Console.WriteLine("Видрукувати погоду в тi днi, коли тиск був нижче введеного числа");
            Console.WriteLine("Enter Pressure: (0-1000) ");
            double newPressure = Convert.ToDouble(Console.ReadLine());

            for (i = 0; i < 12; i++)
            {
                // Видрукувати погоду в ті дні, коли тиск був нижче введеного числа
                if (weather[i].Pressure < newPressure)
                {
                    weather[i].Print(weather[i].Temperature, weather[i].Pressure, weather[i].Wind, weather[i].Precipitation);
                }

                // Обчислити середню температуру безвітряних днів.
                if ((string)weather[i].Wind == "Tquiet")
                {
                    avgTemperature = avgTemperature + weather[i].Temperature;
                    countTemperature++;
                }

                // Видрукувати погоду в ті дні, коли тиск був нижче введеного числа
                if ((string)weather[i].Precipitation == "WithoutPrecipitation")
                {
                    countWithoutPrecipitation++;
                }
               else if ((string)weather[i].Precipitation == "Rain")
                {
                    countRain++;
                }
                else if ((string)weather[i].Precipitation == "Snow")
                {
                    countSnow++;
                }
            }

            Console.WriteLine("Обчислити середню температуру безвiтряних днiв.");
            Console.WriteLine("AvrTemperature {0}", avgTemperature / countTemperature);
            Console.WriteLine("Порахувати скiльки днiв падав дощ, снiг, а скiльки було без опадiв");
            Console.WriteLine("Rain: {0} Snow: {1} WithoutPrecipitation: {2}", countRain, countSnow, countWithoutPrecipitation);

            Console.WriteLine("Видрукувати прогнози погоди в порядку спадання температур");
            int temp = 0;
            for (i = 0; i < 12; i++)
            {
                for (int sort = 0; sort < 11; sort++)
                {
                    if (weather[sort].Temperature > weather[sort + 1].Temperature)
                    {
                        temp = (int)weather[sort + 1].Temperature;
                        weather[sort + 1].Temperature = weather[sort].Temperature;
                        weather[sort].Temperature = temp;
                    }
                }
            }

            for (i = 0; i < 12; i++)
            {
                weather[i].Print(weather[i].Temperature, weather[i].Pressure, weather[i].Wind, weather[i].Precipitation);
            }

            Console.ReadKey();
        }
    }
}
