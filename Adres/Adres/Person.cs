using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adres
{
    class Person
    {
        public string City;
        public string Street;
        public int HouseNumber;

        public Person(Person person)
        {
            this.City = person.City;
            this.Street = person.Street;
            this.HouseNumber = person.HouseNumber;
        }
        public Person()
        {
                                        
        }
    }
}
