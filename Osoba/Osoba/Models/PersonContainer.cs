using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba.Models
{
    class PersonContainer
    {
        public List<Person> People;

        public PersonContainer()
        {
            People = new List<Person>();

            People.Add(new Person("Jan Kowalski", "1998", "654874876"));
            People.Add(new Person("Mirabella Kowalska", "1890","56543645"));
            People.Add(new Person("Gondola Mariuszko", "2005","52365376"));
        }

        public Person this[string key]
        {
            get
            {
                foreach(Person person in People)
                {
                    if (person.Pesel == key)
                        return person;
                }
                return null;
            }

        }
    }
}
