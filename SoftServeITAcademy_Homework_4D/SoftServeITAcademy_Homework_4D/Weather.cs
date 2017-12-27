using System;

namespace SoftServeITAcademy_Homework_4D
{
    public enum Winds
    {
        Quiet = 't', Light = 'l', Moderate = 'p', Strong = 's'
    }

    public enum Precipitations
    {
        WithoutPrecipitation = 0, Rain = 1, Snow = 2
    }

    public class Weather
    {
        private double _temperature;
        private double _pressure;
        private Winds _wind;
        private Precipitations _precipitation;

        public Weather() { }

        public Weather(double temperature, double pressure, Winds wind, Precipitations precipitation)
        {
            this._temperature = temperature;
            this._pressure = pressure;
            this._wind = wind;
            this._precipitation = precipitation;
        }

        public double Temperature
        {
            get => this._temperature;
            set => this._temperature = value;
        }

        public double Pressure
        {
            get => this._pressure;
            set => this._pressure = value;
        }

        public Winds Wind
        {
            get => this._wind;
            set => this._wind = value;
        }

        public Precipitations Precipitation
        {
            get => this._precipitation;
            set => this._precipitation = value;
        }

        public override string ToString()
        {
            return $"Temperature {this._temperature} Pressure {this._pressure} Wind {this._wind} Precipitation {this._precipitation}";
        }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            var parametr = (Weather)obj;
            return (this._wind == parametr._wind) && (this._precipitation == parametr._precipitation);
        }

        public override int GetHashCode()
        {
            return (this._temperature.GetHashCode() * 397) ^ this._pressure.GetHashCode();
        }

        public void Print()
        {
            Console.WriteLine($"{this._temperature}*C \t\t {this._pressure} \t\t {this._wind} \t {this._precipitation}");
        }
    }
}
