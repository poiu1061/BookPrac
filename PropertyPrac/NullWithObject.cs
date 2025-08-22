using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class NullWithObject
    {

    }

    class Person4
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string Street { get; set; } = "알 수 없음";
    }


}
