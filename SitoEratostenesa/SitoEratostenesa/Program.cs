using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitoEratostenesa
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n;
            Console.WriteLine("Podaj górną granicę przedziału, z którego " +
             "chcesz wypisać wszystkie liczby pierwsze.");
            Console.Write("Liczba nie może być większa od ¬{0}: ",
             ulong.MaxValue);
            n = Convert.ToUInt64(Console.ReadLine());
            bool[] liczby = new bool[n - 1];            ulong m = (uint)Math.Sqrt(n);
            ulong index;
            for (ulong i = 2; i <= m; i++)
            {
                if (!liczby[i - 2])
                {
                    index = i * i - 2;
                    while (index < n - 1)
                    {
                        liczby[index] = true;
                        index += i;
                    }
                }
            }
            Console.WriteLine("Liczby pierwsze z podanego przedziału to:");
            int j = 0;
            for (ulong i = 0; i < n - 1; i++)
            {
                if (!liczby[i])
                {
                    Console.Write("{0,22}, ", i + 2);
                    j++;
                    if (j % 2 == 0)
                        Console.WriteLine();
                    if (j % (2 * Console.WindowHeight) == 0)
                        Console.ReadKey();
                }
            }
            Console.Write("\nLiczb pierwszych w podanym zakresie jest {0}", j);
            Console.ReadKey();
        }
    }
}
