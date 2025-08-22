using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class PropertyNotePerson
    {

    }

    public class Person
    {
        private int _BirthYear;

        public string Name { get; set; }

        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                {
                    _BirthYear = value;
                }
                else
                {
                    _BirthYear = 0;
                }
            }
        }

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - _BirthYear);
            }
        }

        public Person(string name)
        {
            Name=name;
        }
    }
}
