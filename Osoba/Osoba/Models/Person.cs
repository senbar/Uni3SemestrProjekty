using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Models
{
    public partial class Person
    {
        public enum SexEnum { Woman, Man }

        public int BirthYear;
        public string FullName;
        public string FirstName;
        public string LastName;

        public SexEnum Sex {
            get
            {
                if (FirstName[-1] == 'a')
                    return SexEnum.Woman;
                return SexEnum.Man;
            }
        }

        public Person(string name,string birthYear)
        {
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
