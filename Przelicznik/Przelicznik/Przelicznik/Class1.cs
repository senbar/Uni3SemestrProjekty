using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik
{
    public class Class1
    {
        public static double KM2Mi(double km)
        {
            return 1.6 * km;
        }

        public static double Mi2KM(double mi)
        {
            return mi / 1.6;
        }
        public static double F2C(double far)
        {
            return (far - 32) * 5 / 9;
        }
        public static double C2F(double cel)
        {
            return (cel / 5 * 9) + 32;
        }
    }
}
