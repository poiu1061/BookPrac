using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class PropertyPrac
    {

    }

    class Fish
    {
        public int Weight { get; set; } = 50;
        public void Feed(int weight) => Weight += weight;
    }
}
