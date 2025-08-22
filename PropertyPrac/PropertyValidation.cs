using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    
    internal class PropertyValidation
    {
    
    }

    class Car3
    {
        public string name { get; set; }
        public Car3(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            this.name = name;
        }
    }

    
   
}
