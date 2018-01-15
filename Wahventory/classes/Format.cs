using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wahventory.classes
{
    class Format
    {
        public static String formatToPeso(double num)
        {
            return num.ToString("C2").Replace('$', '\u20B1');
        }

        public static double formatToDecimal(string text)
        {
            return double.Parse(text.Substring(1), System.Globalization.NumberStyles.Currency);
        }

    }
}
