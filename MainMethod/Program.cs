using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        //Main문의 string[] args또한 문자열을 받아오는 배열이다, 이를 명령줄 인수라고 한다 args = argumets 
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
