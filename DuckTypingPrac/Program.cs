using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckTypingPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var duck = new { Id = 1, Name = "Duck 1" };
            Console.WriteLine($"{duck.Id} - {duck.Name}");

            duck = new { Id = 2, Name = "Duck 2" };
            Console.WriteLine($"{duck.Id} - {duck.Name}");

            //익명타입이라 형변환이 안됨
            //duck = new { Id = 3.14, name = "Duck 3" };

            //이 코드도 실행한됨 또한 임의의 속성을 추가해서 생성해도 실행안됨
            //duck = new { Id = 3 };
        }

         
    }
}
