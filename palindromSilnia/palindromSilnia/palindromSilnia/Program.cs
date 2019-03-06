using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromSilnia
{
    static class Program
    {
        static long Factorial(this long x)
        {
            long y = 1;
            while (x > 1)
            {
                y = y * x;
                x -= 1;
            }
            return y;
        }

        static bool Divisible(this long x, long y)
        {
            return x % y == 0 ? true : false;
        }

        static bool IsPalindrome(this string x)
        {
            for (int i=0; i< (x.Length-1)/2; i++)
            {
                if (x[i] != x[x.Length-1 - i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            long x = 5;
            Console.Write(x.Factorial());
            Console.ReadKey();
        }

    }
}
