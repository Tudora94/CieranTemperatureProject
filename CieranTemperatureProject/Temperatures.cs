using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CieranTemperatureProject
{
    public class Temperatures
    {
        Conversions conversions = new Conversions();

        private string StartingUnit;
        private string conversionUnit;
        private string[] acceptedUnits = { "C", "F", "K" };

        private decimal? Celcius;
        private decimal? Farenheit;
        private decimal? Kelvin;

        public string StartingUnit1 { get => StartingUnit; set => StartingUnit = value; }
        public decimal? Celcius1 { get => Celcius;}
        public decimal? Farenheit1 { get => Farenheit;}
        public decimal? Kelvin1 { get => Kelvin;}
        public string ConversionUnit { get => conversionUnit; set => conversionUnit = value; }

        public bool UnitValidator(string insertedUnit)
        {
            if (acceptedUnits.Contains(insertedUnit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setInitialValue(decimal? UserValue)
        {
            switch (StartingUnit)
            {
                case "C":
                    this.Celcius = UserValue;
                    break;
                case "F":
                    this.Farenheit = UserValue;
                    break;
                case "K":
                    this.Kelvin = UserValue;
                    break;
            }

            calculateAllConversions();

        }

        private void calculateAllConversions()
        {
            switch (StartingUnit)
            {
                case "C":
                    this.Kelvin = conversions.cToK((decimal)Celcius1);
                    this.Farenheit = conversions.CtoF((decimal)Celcius1);
                    break;
                case "F":
                    this.Kelvin = conversions.fToK((decimal)Farenheit1);
                    this.Celcius = conversions.FtoC((decimal)Farenheit1);
                    break;
                case "K":
                    this.Celcius = conversions.kToC((decimal)Kelvin1);
                    this.Farenheit = conversions.kToF((decimal)Kelvin1);
                    break;
            }
        }

        public decimal returnConversion()
        {
            switch (conversionUnit)
            {
                case "C":
                    return (decimal)Celcius;
                case "F":
                    return (decimal)Farenheit;
                case "K":
                    return (decimal)Kelvin;
                default: return 0;
            }
        }

    }
}
