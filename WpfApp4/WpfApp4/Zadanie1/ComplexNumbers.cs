using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class ComplexNumbers
    {
        public double a;
        public double b;
        public string expr;

        public ComplexNumbers(double a, double b)
        {
            this.a = a;
            this.b = b;
            expr = $"{this.a} + {this.b} i";
        }

        public string ToArithmethicExpression()
        {
            expr = $"{a} + {b} i";

            if (a.Equals(Double.NaN) || b.Equals(Double.NaN))
            {
                return "Result is not a number";
            }

            if (a == 0 && b == 0)
                return "0";
            else if (a == 0)
                return $"{b} i";
            else if (b == 0)
                return $"{a}";
            else if (b > 0)
                return $"{a} + {b} i";
            else
                return $"{a} - {Math.Abs(b)} i";
        }

        public string ToTrighonometricExpression()
        {
            double z = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
            double fi = 0;

            if (a.Equals(Double.NaN) || b.Equals(Double.NaN))
            {
                return "Result is not a number";
            }

            if (b >= 0 && z != 0)
            {
                fi = Math.Round(Math.Acos(a / Math.Abs(z)), 2);
            }

            if (z == 0)
            {
                return "Niezdefiniowany";
            }

            if (b < 0)
            {
                fi = -Math.Round(Math.Acos(a / Math.Abs(z)), 2);
            }

            expr = $"{Math.Abs(z)} * (cos({fi}) + i*sin({fi}))";

            return $"{Math.Abs(z)} * (cos({fi}) + i*sin({fi}))";

        }

        public string ToExponentialExpression()
        {
            double z = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), 2);
            double fi = 0;

            if (a.Equals(Double.NaN) || b.Equals(Double.NaN))
            {
                return "Result is not a number";
            }

            if (b >= 0 && z!=0)
            {
                fi = Math.Round(Math.Acos(a / Math.Abs(z)), 2);
            }

            if (z == 0)
                return "Niezdefiniowany";

            if (b < 0)
            {
                fi = -Math.Round(Math.Acos(a / Math.Abs(z)), 2);
            }

            expr = $"{Math.Abs(z)} e^(i * {fi})";

            return $"{Math.Abs(z)} e^(i * {fi})";

        }
    }
}
