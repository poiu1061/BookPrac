using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FieldPrac
{
    internal class Program
    {
        #region 접근제한자
        //접근제한자
        //public :멤버에 대한 접근이 제한되지않음 모든 곳에서 접근가능
        //private : 현재 클래스 내에서만 접근이 가능
        //protected: 현재 클래스 및 현재 클래스를 상속하는 자식 클래스에만 접근이 허가
        //internal: 현재 프로젝트의 모든 클래스에서 접근이 허가됨
        //protected internal :현재 어셈블리 또는 어셈블리에서 파생된 모든 클래스에서 엑세스가 허가됨

        public class Car
        {
            public static void Hi() { Console.WriteLine("Hi"); }
            private static void Bye() { Console.WriteLine("Bye"); }
            public static string name;
            private static int age;

            protected string protectedField = "Protected Field";
            internal string internalField = "Internal Field";
            protected internal string protectedInternalField = "Protected Internal Field";

            //private한 필드를 외부에 공개할 때는 public한 메서드로 공개
            public static void SetAge(int intAge) { age = intAge; }
            public static int GetAge() { return age; }
        }

        public class SportsCar : Car
        {
            public void ShowAccess()
            {
                // 상속받은 클래스이므로 protected 접근 가능
                Console.WriteLine("From SportsCar (자식 클래스):");
                Console.WriteLine(protectedField);                //car를 상속받았기 때문에 접근 가능
                Console.WriteLine(internalField);                 //같은 프로젝트라 접근 가능
                Console.WriteLine(protectedInternalField);        //
            }
        }

        #endregion

        class Person
        {
            private string name = "박용준";                                 //변수 형식의 필드
            private const int m_age = 21;                                   //상수 형식의 필드
            private readonly string _NickName = "RedPlus";                   //읽기 전용 필드
            private string[] websites = { "닷넷코리아", "비주얼아카데미" }; //배열 형식의 필드
            private object all = DateTime.Now.ToShortTimeString();          //모든 형식의 필드

            public void ShowProfile()
            {
                string r =
                    $"{name},{m_age},{_NickName}.{String.Join(",", websites)}," +
                    $"{Convert.ToDateTime(all).ToShortTimeString()}";
                Console.WriteLine(r);
            }
        }


        static void Main(string[] args)
        {
            #region 접근제한자 출력
            Car.Hi();
            //private기 때문에 접근할 수없음
            //Car.Bye();

            Car.name = "RedPlus";
            Console.WriteLine(Car.name);

            Car.SetAge(21);
            Console.WriteLine(Car.GetAge());


            SportsCar myCar = new SportsCar();
            myCar.ShowAccess();

            Car baseCar = new Car();

            Console.WriteLine("\nFrom Main (외부 클래스):");

            Console.WriteLine(baseCar.internalField);
            Console.WriteLine(baseCar.protectedInternalField);
            #endregion

            Person person = new Person();
            person.ShowProfile();


        }
    }
}


