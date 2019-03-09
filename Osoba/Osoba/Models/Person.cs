using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Models
{
    public class Person
    {

        public int BirthYear;
        public string FullName;
        public string FirstName;
        public string LastName;
        public string Pesel;

        public string Sex {
            get
            {
                if (FirstName.Last() == 'a')
                    return "Kobieta";
                return "Mezczyzna";
            }
        }

        public Person(string name,string birthYear, string pesel)
        {
            this.Pesel = pesel;

            string[] splitted = name.Split(' ');
            if (splitted.Count() != 2)
                throw new Exception();
            FullName = name;

            FirstName = splitted[0];
            LastName = splitted[1];
            BirthYear=int.Parse(birthYear);
        }
    }
}
