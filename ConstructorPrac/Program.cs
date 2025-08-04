using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPrac
{
    internal class Program
    {
        //생성자란 클래스를 통해 무언가 만들고싶을때 해등 클래스를 사용하겠다고 선언해주는 메서드
        static void Main(string[] args)
        {
            ConstructorDemo c = new ConstructorDemo();

            Dog Happy = new Dog("해피");
            Console.WriteLine(Happy.Cry());

            Dog Worry = new Dog("워리");
            Console.WriteLine(Worry.Cry());

            My my = new My("지훈", 30);
            my.PrintMy();

            Circle cir = new Circle(10);
            Console.WriteLine(cir.Area());

            //정적 생성자 실행
            Person.Show();

            //인스턴스 생성자 실행
            (new Person()).Print();
            (new Person(22)).Print();

            new Say("[2] 잘가요");

            var file = new WhitchService("[1] 파일 로그");
            file.Run();

            var pet = new Pet("야옹이");
            pet.ToString();
        }

        class ConstructorDemo //클래스
        {
            public ConstructorDemo() //생성자
            {
                Console.WriteLine("생성자가 호출되었습니다");
            }
        }

        public class Dog
        {
            private string name;
            public Dog(string name)
            {
                this.name = name;
            }
            public string Cry()
            {
                return name + "이(가) 멍멍멍";
            }
        }

        class My
        {
            private string _name;
            private int _age;

            public My(string name, int age)
            {
                this._name = name;
                this._age = age;
            }

            public void PrintMy()
            {
                Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
            }
        }

        public class Circle
        {
            private int _radius;

            public Circle(int radius)
            {
                this._radius = radius;
            }

            public double Area()
            {
                return Math.PI * _radius * _radius;
            }
        }

        public class Person
        {
            private static readonly string _Name;
            private int _Age;

            static Person() { _Name = "홍길동"; }
            public Person() { _Age = 21; }

            public Person(int _Age)
            {
                this._Age = _Age;
            }

            public static void Show()
            {
                Console.WriteLine("이름 : {0}", _Name);
            }

            public void Print()
            {
                Console.WriteLine("나이 : {0}", _Age);
            }



        }

        class Say
        {
            private string message = "[1] 안녕하세요";
            public Say() => Console.WriteLine(this.message);

            public Say(string message) : this()
            {
                this.message = message;
                Console.WriteLine(this.message);
            }
        }

        public class WhitchService
        {
            private readonly string _serviceName;
            public WhitchService(string serviceName)
            {
                _serviceName = serviceName;
            }
            public void Run() => Console.WriteLine($"{_serviceName} 기능을 실행합니다.");
        }

        class Pet
        {
            private string _name;

            public Pet(string name) => _name = name;
            public override string ToString()
            {
                return _name;
            }
        }


        //C# 12이전 버전의 생성자 생성방식
        class Employee
        {
            private readonly string _name;
            private readonly int _age;

            public Employee(string name, int age)
            {
                _name = name;
                _age = age;
            }
        }

        //**C# 12이상 버전의 기본생성자 활용방법**
        //class Employees(string name, int age)
        //{
        //    private readonly string _name = name;
        //    private readonly int _age = age;

        //    public void Display() =>
        //        Console.WriteLine($"이름 : {name},나이 : {_age}");
        //}
    }
}
