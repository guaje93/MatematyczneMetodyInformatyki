using System;

namespace WpfApp4
{
    public static class ComplexNumbersCalculator
    {
        //Klasa statyczna kalkulatora
        //Metody dodawanie, odejmowanie, mnożenie, dzielenie
        public static ComplexNumbers AddingCalculator(ComplexNumbers z1, ComplexNumbers z2)
        {            
            double a1 = z1.a;
            double a2 = z2.a;
            double b1 = z1.b;
            double b2 = z2.b;

            return new ComplexNumbers(Math.Round(a1 + a2, 2), Math.Round(b1 + b2, 2));    
        }

        public static ComplexNumbers SubstractingCalculator(ComplexNumbers z1, ComplexNumbers z2)
        {
            double a1 = z1.a;
            double a2 = z2.a;
            double b1 = z1.b;
            double b2 = z2.b;

            return new ComplexNumbers(Math.Round(a1 - a2, 2), Math.Round(b1 - b2, 2));            
        }

        public static ComplexNumbers MultiplyingCalculator(ComplexNumbers z1, ComplexNumbers z2)
        {
            double a1 = z1.a;
            double a2 = z2.a;
            double b1 = z1.b;
            double b2 = z2.b;

            return new ComplexNumbers(Math.Round(a1 * a2 - b1 * b2, 2), Math.Round(b1 * a2 + a1 * b2, 2));
        }

        public static ComplexNumbers DividingCalculator(ComplexNumbers z1, ComplexNumbers z2)
        {
            double a1 = z1.a;
            double a2 = z2.a;
            double b1 = z1.b;
            double b2 = z2.b;

            return new ComplexNumbers(Math.Round((a1 * a2 + b1 * b2) / (a2 * a2 + b2 * b2), 2), Math.Round((b1 * a2 - a1 * b2) / (a2 * a2 + b2 * b2), 2));
        }
    }

}

