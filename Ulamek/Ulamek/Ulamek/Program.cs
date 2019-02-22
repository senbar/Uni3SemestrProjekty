using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamek
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction[] fractions= new Fraction[2];

            for (int i = 0; i < 2; i++)
            {
                int inumerator, idenominator;
                string numerator, denominator;

                do
                {
                    do
                    {
                        Console.WriteLine(String.Format("podaj {0} ulamek", i == 0 ? "pierwszy" : "drugi"));
                        numerator = Console.ReadLine();
                        denominator = Console.ReadLine();

                        int z = 0;
                    } while (!(
                    int.TryParse(numerator, out inumerator)
                    && int.TryParse(denominator, out idenominator))
                    );
                } while (idenominator == 0);

                fractions[i] = new Fraction(inumerator,idenominator);
            }

            Console.WriteLine(String.Format("iloczyn tych ulamkow to {0}/{1}",(fractions[0]*fractions[1]).Numerator,
                (fractions[0]*fractions[1]).Denominator));

            Console.ReadKey();

        }
    }
}
