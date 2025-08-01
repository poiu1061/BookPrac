using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac
{
    internal class Program
    {
        static string message = "전역변수";
        static void Main(string[] args)
        {
            //재귀를 이용한 factorial 구하기
            Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(FactorialFor(4));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Fact(4));


            //재귀를 이용한 n의 m승구하기
            Console.WriteLine(MyPower(2,2));

           
        }

        static int Fact(int n)
        {
            if(n ==0 || n == 1)
            {
                return (n > 1) ? n * Fact(n - 1) : 1;
            }
            return n * Fact(n - 1);
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);

        }

        static int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 1; i <=n; i++)
            {
                result *= i;
            }
            return result;

        }

        //승구하기 메서드
        static int MyPower(int num, int cnt)
        {
            if(cnt == 0)
            {
                return 1;
            }
            return num * MyPower(num, --cnt);
        }
    }
}
