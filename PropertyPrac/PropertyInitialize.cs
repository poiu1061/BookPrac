using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class PropertyInitialize
    {

    }

    class Pet
    {
        public int Weight { get; set; }

        public void Feed(int weight)
        {
            Weight += weight;
        }
    }

    
}
