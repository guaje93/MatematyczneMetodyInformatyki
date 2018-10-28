using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public static class Converter
    {
        public static double StringToDoubleConverter(string input)
        {
            return Double.Parse(input);
        }

        public static string DoubleToStringConverter(double input)
        {
            return input.ToString(); ;
        }
    }
}
