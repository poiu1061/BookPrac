using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class ObjectInitializer
    {
    
    }

    public class Person3
    {
        //propfull : 전체속성
        private string _Name;
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        //prop : 자동으로 구현된 속성

        public int Age { get; set; }

        //자동속성: 속성을 자동으로 초기화(c#6.0)
        public string Type { get; set; } = "사람";
    }
}
