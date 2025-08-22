using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassPrac
{

    #region 부분클래스로 나누어 메서드와 속성을 나누어 관리
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name} : {Age}");
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 부분클래스로 나누어 메서드와 속성을 나누어 관리
            Person person = new Person();

            person.Name = "C#";
            person.Age = 25;

            person.Print();
            #endregion


        }
    }
}
