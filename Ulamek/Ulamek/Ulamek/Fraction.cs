using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamek
{
    class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new FormatException("denominator can not be 0");

            Numerator = numerator;
            Denominator = denominator;
        }


        public static Fraction operator *(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Numerator, first.Denominator * second.Denominator);
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator + second.Numerator * first.Denominator,
                first.Denominator * second.Denominator);
        }
    }
}
