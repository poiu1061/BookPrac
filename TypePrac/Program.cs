using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //is 연산자는 특정 개체가 특정 형식인지 확인할때 사용된다
            #region is
            object x = 123;

            if(x is int)
            {
                Console.WriteLine($"{x}는 정수형으로 변환이 가능합니다.");
            }
            #endregion

            #region As
            //as는 변환하는 형식이 해당 데이터 형식과 일치하면 그대로 변환하지만 아닐경우  null을 반환
            object t = "반갑습니다.";
            string r1 = t as string;
            Console.WriteLine($"[1] {r1}");

            object i = 1234;
            string r2 = i as string;
            if(r2 == null)
            {
                Console.WriteLine("[2] null입니다.");
            }

            object i2 = "3456";
            if(i2 is string)
            {
                string r3 = i2 as string;
                Console.WriteLine($"[3] {r3}");
            }
            else
            {
                Console.WriteLine("[3] 변환불가.");
            }
            #endregion

            #region if문과 is연산자 활용하기

            PrintStars(null);
            PrintStars("하나");
            PrintStars(7);
            #endregion
        }

        static void PrintStars(object o)
        {
            if(o is null)
            {
                return;
            }

            if (o is string)
            {
                return;
            }

            //패턴 매칭: 넘어온 값이 정수 형식이면 int number = o;
            if(!(o is int number))
            {
                return; //정수 이외의 값 제외
            }
            Console.WriteLine(new String('*', number));


        }
    }
}
