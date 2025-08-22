using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNameOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NameToString");
            Console.WriteLine(nameof(NameToString));


            //익명 객체
            var data = new { Id = 1, Name = "익명형식" };
            Console.WriteLine($"{data.Id} - {data.Name}");

            var presenter = new { Name = "박용준", Age = 50, Topic = "C#" };
            Console.WriteLine($"{presenter.Name}, {presenter.Age}, {presenter.Topic} ");

            var developers = new[]
            {
                new { Name = "RedPlus",Age = 50},
                new { Name = "Taeyo", Age = 55}
            };
        }

        static void NameToString()
        {

        }
       
    }

   
}
