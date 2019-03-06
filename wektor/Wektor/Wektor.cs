using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wektor
{
    class Wektor
    {
        public List<double> coords;
        public Wektor()
        {
            coords = new List<double>();
        }
        public static Wektor operator +(Wektor v1,Wektor v2)
        {
            Wektor sum = new Wektor();
            if (v1.coords.Count != v2.coords.Count)
                throw new ArithmeticException("wrong vector sizes");
            for(int i=0; i<v1.coords.Count; i++)
            {
                sum.coords.Add(v1.coords[i] + v2.coords[i]);
            }

            return sum;
        }
        public static Wektor operator -(Wektor v1, Wektor v2)
        {
            for(int i = 0; i < v2.coords.Count; i++)
            {
                v2.coords[i] *= -1;
            }
            return v1 + v2;
        }

        public static Wektor operator *(Wektor v1, double scalar)
        {
            for(int i=0; i<v1.coords.Count; i++)
            {
                v1.coords[i] *= scalar;
            }
            return v1;
        }
    }
}
