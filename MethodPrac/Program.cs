using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrac
{
    internal class Program
    {
        static string message = "전역변수";

        static void Main(string[] args)
        {
            Console.WriteLine(message);
            ShowMessage();

            //화살표 함수 사용하기(Lamda)
            Hi();
            Multiply(3, 4);

            //식 본문 메서드
            Log("함수 축약");
            Console.WriteLine(IsSame("A", "B"));

            //Local method(로컬 함수)
            void Display(string text)
            {
                Console.WriteLine(text);
            }

            Display("로컬 함수");

            //local method 내에 식 본문 메서드 사용하기
            int Add(int a, int b) => a + b;
            decimal Subtract(decimal x, decimal y) => x - y;

            Console.WriteLine($"3+5 = {Add(3,5)}");
            Console.WriteLine($"34.56 - 12.34 = {Subtract(34.56m,12.34m)}");

        }

        static void ShowMessage()
        {
            //새로운 지역변수를 할당한것 전역변수와 상관없음
            string message = "지역변수";

            //message ="지역변수"; 라고선언했을경우 전역변수로 선언된 message의 값이 바뀜 즉 앞에 자료형을 선언하고
            //안하고에따라 기존에 있는 전역변수를 사용할것인지 지역변수를 사용할것인지 나뉨
            Console.WriteLine(message);
        }

        static void Hi() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a * b);

        static void Log(string message) => Console.WriteLine(message);
        static bool IsSame(string a, string b) => a == b;
    }

}
