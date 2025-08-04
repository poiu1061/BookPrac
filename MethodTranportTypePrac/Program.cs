using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTranportTypePrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //메서드의 매개변수 전달방식
            //1. 값 전달방식 : 값 전달 방식 : 말 그대로 값을 그대로 복사해서 전달하는 방식을 의미
            //2. 참조 전달 방식 : 실제 데이터는 매개변수가 선언된 쪽에서만 저장하고, 호출된 메서드에서는 참조만 하는 형태로 변수 이름만 전달하는 방식
            //3. 반환형 전달 방식 : 메서드를 호출하는 쪽에서 선언만 하고 초기화하지 않은 ;채 전달하면서 메서드 쪽에서 해당 데이터를 초기화해서 넘겨주는 방식
            //4. 가변형 전달 방식 : 1개 이상의 매개변수를 가변적으로 받을 때 매개변수를 선언하면 params 키워드를 붙인다
            //                      가변적이라는 것은 같은 타입으로 하나 이상을 받을 수 있도록 배열형으로 받는다는 의미

            int num;
            Do(out num);
            Console.WriteLine($"[2] {num}");

            #region 값 전달방식
            //static void Do(int num)
            //{
            //    num = 20;
            //    Console.WriteLine($"[2] {num}");
            //}
            //Do(num);
            #endregion

            #region 참조형 ref방식
            //static void Do(ref int num)
            //{
            //    num = 20;
            //    Console.WriteLine($"[2] {num}");
            //}
            //Do(ref num);
            #endregion

            #region 가변길이
            Console.WriteLine(SumAll(3, 5));
            Console.WriteLine(SumAll(3, 5, 7));
            Console.WriteLine(SumAll(3, 5, 7, 9));
            #endregion

        }

        //반환형 매개변수 전달 방식
        static void Do(out int num)
        {
            num = 1234;   //ref와 동일: 호출한 부분에 적용, 반드시 초기화해야 함
            Console.WriteLine($"[1] {num}");
        }

        //가변길이 매개변수
        static int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Multi(params string[] s)
        {
            foreach (string a in s)
            {
                Console.WriteLine(a);
            }
        }
    }
}
