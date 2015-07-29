using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public static class DoubleExtension
    {
        public static double RoundedTaxRate(this double d)
        {
            return Convert.ToDouble(Math.Ceiling(d * 20.0)) / 20.0;
        }
    }
}
