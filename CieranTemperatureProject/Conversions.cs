using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CieranTemperatureProject
{
    internal class Conversions
    {
        public decimal cToK(decimal C)
        {
            return Math.Round(C + Convert.ToDecimal(273.15));
        }

        public decimal fToK(decimal F)
        {
            return Math.Round((F + Convert.ToDecimal(459.67)) * ((decimal)5 / (decimal)9));
        }

        public decimal kToC(decimal K)
        {
            return Math.Round(K - Convert.ToDecimal(273.15));
        }

        public decimal FtoC(decimal F)
        {
            return Math.Round((F - 32) * ((decimal)5 / (decimal)9));
        }

        public decimal CtoF(decimal C)
        {
            return Math.Round((C * ((decimal)9 / (decimal)5)) + 32);
        }

        public decimal kToF(decimal K)
        {
            return Math.Round((K - Convert.ToDecimal(273.15) * ((decimal)9 / (decimal)5)) + 32);
        }


    }
}
