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
        public static Fraction operator -(Fraction first, Fraction second)
        {
            second.Numerator *= -1;
            return first + second;
        }
        public static Fraction operator /(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator, first.Denominator * second.Numerator);
        }
        public static Fraction operator ++(Fraction f)
        {
            f.Numerator += f.Denominator;
            return f;
        }
        public static Fraction operator --(Fraction f)
        {
            f.Numerator -= f.Denominator;
            return f;
        }
        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public void Simplify()
        {
            int hGCD = GCD(this.Numerator, this.Denominator);
            this.Numerator /= hGCD;
            this.Denominator /= hGCD;
        } 

        public static bool operator ==(Fraction first, Fraction second)
        {
            first.Simplify();
            second.Simplify();
            return (first.Numerator == second.Numerator && first.Denominator == second.Denominator);
        } 

        public static bool operator !=(Fraction first, Fraction second)
        {
            return !(first == second);
        }
        public static bool operator true(Fraction f)
        {
            return f.Numerator != 0;
        }
        public static bool operator false(Fraction f)
        {
            return f.Numerator == 0;
        }
    }
}
