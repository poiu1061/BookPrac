using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePrac
{
    internal class Program
    {
        /*
        Action 대리자 : 반환값이 없는 메서드를 대신호출
        Func 대리자 : 매개변수와 반환값이 있는 메서드를 대신 호출
        Predicate 대리자 : T매개변수에 대한 bool값을 반환하는 메서드를 대신 호출
        */
        #region 대리자를 사용하여 메서드 여러개를 호출하기
        public class CarDriver
        {
            public static void GoForward() => Console.WriteLine("직진");
            public static void GoLeft() => Console.WriteLine("좌회전");
            public static void GoRight() => Console.WriteLine("우회전");
        }

        

        public class Insa
        {
            public void Bye() => Console.WriteLine("잘가");
        }

        public delegate void GoHome();

        public delegate void Say();
        private static void Hello() => Console.WriteLine("Hello");
        private static void Hi() => Console.WriteLine("Hi");


        #endregion


        #region 익명 메서드
        public class Print
        {
            public static void Show(string msg) => Console.WriteLine(msg);
        }

        public delegate void PrintDelegate(string msg);
        public delegate void SumDelegate(int a, int b);
        #endregion

        #region 대리자로 메서드 또는 람다식 대신 호출하기
        static string Add(int a, int b) => (a + b).ToString();
        #endregion

        #region 메서드의 매개변수로 메서드 전달
        static int StringLength(string data) => data.Length;

        static void StringLengthPrint(Func<String, int> stringLength, string message)
              => Console.WriteLine($"메세지의 크기는 {stringLength(message)}입니다.");
        #endregion
        static void Main(string[] args)
        {
            #region 대리자를 사용하여 메서드 여러개를 호출하기
            //1 : 메서드는 따로따로 호출
            CarDriver.GoLeft();
            CarDriver.GoForward();
            CarDriver.GoRight();

            //2: 대리자를 사용한 메서드 등록 및 호출
            GoHome go = new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoLeft);
            go();

            Console.WriteLine();

            //3: 대리자를 사용하여 한 번에 메서드 2개 호출...
            Say say;
            say = new Say(Hi);
            say += new Say(Hello);
            say();

            //4 : 대리자를 ㅍ사용하여 호출
            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();
            #endregion


            #region 익명 메서드
            Console.WriteLine();
            //1 : 메서드 직접호출
            Print.Show("안녕하세요");

            //2 : 대리자에 메서드 등록 후 호출
            PrintDelegate pd = new PrintDelegate(Print.Show);
            pd("반갑습니다");

            //3: 익명(무명) 메서드 호출 : delegate 키워드로 익명 메서드 생성
            PrintDelegate am = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            am("또 만나요");

            //4익명 메서드 생성 및 호출
            SumDelegate sd = delegate (int a, int b) { Console.WriteLine(a+b); };
            sd(3, 5);
            #endregion

            #region action, Func,Predicate
            //Action<T> Console.WriteLine같은 메서드를 대신 호출 할 수 있다.
            Action<string> printf = Console.WriteLine;
            printf("메서드 대신 호출");

            //Func<T> = Func<매개변수 형식,반환값형식>
            Func<int, int> abs = Math.Abs;
            abs(-10);

            Func<double, double, double> pow = Math.Pow;
            Console.WriteLine(pow(2, 20));

            Func<string, string> toLower = str => str.ToLower();
            Console.WriteLine(toLower("LambdaExpression"));

            Func<int, int> anonymous = delegate (int x) { return x * x; };
            anonymous(2);

            Func<int, double> lambda = x => x / (double)2;
            lambda(3);
            #endregion

            #region 익명메서드와 람다식 비교
            Func<int> getNumber1 = delegate () { return 1234; };
            getNumber1();

            Func<int> getNumber2 = () => 1234;
            getNumber2();

            Func<int, int> addOne1 = delegate (int x) { return x + 1; };
            addOne1(10);

            Func<int, int> addOne2 = x => x + 1;

            Func<string, string, string> plus1 = delegate (string a, string b) { return a + b; };
            Console.WriteLine(plus1("안녕", "유지훈"));

            Func<string, string, string> plus2 = (a, b) => (a + b);
            Console.WriteLine(plus2("난", "너야"));

            Console.WriteLine();

            #endregion


            #region Func대리자로 메서드 대신 호출하기
            Func<int, bool> zero = number => number == 0;
            Console.WriteLine(zero(1234 - 1234));

            Func<int, int> plusOne = number => number + 1;
            Console.WriteLine(plusOne(4));

            Func<int, int, int> Sum = (a, b) => a + b;
            Console.WriteLine(Sum(4, 6));

            Console.WriteLine();

            #endregion

            #region Func 대리자로 메서드 또는 람다식 대신 호출하기
            //1: Add함수 직접 호출
            Console.WriteLine(Add(3, 5));

            //2.Func 대리자로 Add함수 대신 호출: 반환값이 있는 메서드를 대신 호출
            Func<int, int, string> AddDelegate = Add;//Add메서드 대신 호출
            Console.WriteLine(AddDelegate(3, 5));

            //3 람다식 메서드 ->익명 메서드->람다식으로 줄여 표현
            Func<int, int, string> AddLambda = (a, b) => (a + b).ToString();
            Console.WriteLine(AddLambda(3, 5));
            #endregion

            #region Predicate 대리자 사용하기
            Predicate<string> isNullOrEmpty = String.IsNullOrEmpty;
            Console.WriteLine(isNullOrEmpty("Not Null"));
            Console.WriteLine(isNullOrEmpty(""));
            #endregion

            #region 메서드의 매개변수로 메서드 전달
          
            #endregion
        }

    }
}
