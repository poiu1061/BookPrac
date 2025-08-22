using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPrac
{
    internal class Program
    {
        #region lambda의 기초
        delegate int IntParameterAndIntRturnDeleaget(int x);

        delegate void Lamda();

        delegate int Lambda2(int i);
        Lambda2 square = x => x * x;

        delegate bool Lambda(string msg, int len);

        delegate void Hi();
        #endregion

        #region 메서드의 매개변수에 대리자 형식 사용하기
        delegate void Runner();
        #endregion

        static void Main(string[] args)
        {
            #region 람다의 기초
            IntParameterAndIntRturnDeleaget pow = (x) => x * x;

            Console.WriteLine(pow(3));

            Lamda hi = () => Console.WriteLine("안녕하세요");
            hi();

            Lambda isLong = (string msg, int len) => msg.Length > len;
            isLong("안녕하세요", 5);

            Hi hi2 = () =>
            {
                Console.WriteLine("안녕하세요");
                Console.WriteLine("반갑습니다");
            };
            hi2();
            #endregion

            #region 메서드의 매개변수에 대리자 형식 사용하기
            RunnerCall(new Runner(Go));
            RunnerCall(new Runner(Back));
            #endregion
        }

        static void RunnerCall(Runner runner) => runner();
        static void Go() => Console.WriteLine("직진");
        static void Back() => Console.WriteLine("후진");
    }
}
