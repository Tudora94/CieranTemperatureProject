using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CieranTemperatureProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startingUnit = "";
            string conversionUnit = "";
            decimal? userTemp = new decimal?();

            Console.WriteLine($"Welcome to the Temperature Converter!" +
    $"\n ===============================================" +
    $"\n Available Units are: " +
    $"\n (C)elcius. (F)ahrenheit. (K)elvin");

            while (userTemp == null)
            {
                try
                {
                    Console.WriteLine("Enter Temperature to Convert:");
                    userTemp = decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number\n");
                }
            }

            Temperatures temperatures = new Temperatures();

            while (true)
            {
                Console.WriteLine("Enter Unit");
                startingUnit = Console.ReadLine().ToUpper();

                if (temperatures.UnitValidator(startingUnit))
                {
                    temperatures.StartingUnit1 = startingUnit;
                    break;

                } else
                {
                    Console.WriteLine("Invalid Temperature Unit added\n.");
                }
            }

            temperatures.setInitialValue(userTemp);

            while (true)
            {
                Console.WriteLine("Enter Unit to Convert to!");
                conversionUnit = Console.ReadLine().ToUpper();

                if (temperatures.UnitValidator(conversionUnit))
                {
                    temperatures.ConversionUnit = conversionUnit;
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid Temperature Unit added\n.");
                }
            }

            decimal convertedUnit = temperatures.returnConversion();
            string response = string.Format("{0}{1} converts to {2}{3}", userTemp, startingUnit, convertedUnit, conversionUnit);
            Console.WriteLine(response);
        }
    }
}
