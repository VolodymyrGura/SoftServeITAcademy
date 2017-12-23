using System;

namespace SoftServeITAcademy_Homework_4D
{
   public class Weather
    {
        private double temperature;
        private double pressure;
        private string wind;
        private string precipitation;

        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                this.temperature = value;
            }
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }

            set
            {
                this.pressure = value;
            }
        }

        public string Wind
        {
            get
            {
                return this.wind;
            }

            set
            {
                this.wind = value;
            }
        }

        public string Precipitation
        {
            get
            {
                return this.precipitation;
            }

            set
            {
                this.precipitation = value;
            }
        }

        public Weather()
        {
        }

        public Weather(double temperatures, double pressures, string winds, string precipitations)
        {
            this.temperature = temperatures;
            this.pressure = pressures;
            this.wind = winds;
            this.pressure = pressures;
        }

        public override string ToString()
        {
            return "Temperature " + this.temperature + "Pressure " + this.pressure + "Wind " + this.wind + "Precipitation" + this.precipitation;
        }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Weather parametr = (Weather)obj;
            return (this.wind == parametr.wind) && (this.precipitation == parametr.precipitation);
        }

        public void Print(double temperature, double pressure, string wind, string precipitation)
        {
            Console.WriteLine("{0}*C         \t {1} \t   {2} \t   {3} ", this.temperature, this.pressure, this.wind, this.precipitation);
        }
    }
}
