using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adres
{
    class Program
    {
        static void Main(string[] args)
        {
            Person z = new Person();
            z.City = "katowice";
            z.Street = "adfs";
            z.HouseNumber = 4;

            Person s = new Person(z);
            Console.Write(s.City +'\n' +s.Street + '\n' +s.HouseNumber.ToString());
            Console.ReadKey();
        }

        
    }
}
    