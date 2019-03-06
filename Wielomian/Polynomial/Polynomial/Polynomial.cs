using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Polynomial
    {
        List<double> coords;
        public Polynomial()
        {
            coords = new List<double>();
        }
        public Polynomial (int degree)
        {
            coords = new List<double>(degree);
        }
        public static Polynomial operator+(Polynomial p1, Polynomial p2)
        {
            if (p1.coords.Count > p2.coords.Count)
                return (p2 + p1);
            for(int i=0; i<p1.coords.Count; i++)
            {
                p2.coords[i] += p1.coords[i];
            }
            return p2;
        }

        public static Polynomial operator-(Polynomial p1, Polynomial p2)
        {
            for(int i=0; i<p2.coords.Count; i++)
            {
                p2.coords[i] *= -1;
            }
            return p1 + p2;
        }
        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            Polynomial result = new Polynomial(p1.coords.Count+ p2.coords.Count);
            for(int i=0; i<p1.coords.Count; i++)
            {
                for(int j=0; j<p2.coords.Count; i++)
                {
                    result.coords[i + j] = p1.coords[i] + p2.coords[j];
                }
            }
            return result;
        }
        public double Horner(double x)
        {
            double wynik = this.coords[0];
            for (int i = 0; i < this.coords.Count; i++)
                wynik = wynik * x + this.coords[i];
            return wynik;
                
        }
        
    }
}
