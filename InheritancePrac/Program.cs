using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    internal class Program
    {
        #region 상속의 기본예제
        class Parent
        {
            public void Foo() => Console.WriteLine("부모 클래스의 멤버 호출");
        }

        class Child : Parent
        {
            public void Bar() => Console.WriteLine("자식 클래스의 멤버 호출");
        }
        #endregion

        #region 부모 클래스 형식 변수에 자식 클래스의 개체 할당하기
        class Developer
        {
            public override string ToString()
            {
                return "개발자";
            }
        }

        class WebDeveloper : Developer
        {
            public override string ToString()
            {
                return "개발자";
            }
        }

        class MobileDeveloper : Developer
        {
            public override string ToString()
            {
                return "모바일 개발자";
            }
        }
        #endregion

        #region 상속 관계 구현
        class Vehicle { }

        class Car : Vehicle { }

        class Airplane : Vehicle { }
        #endregion

        #region 클래스 상속을 사용한 부모의 protected 멤버에 접근하기
        public class ParentClass: Object
        {
            protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
        }

        public class ChildClass : ParentClass
        {
            public void Print2() => base.Print1();
        }

        #endregion

        #region base 키워드를 사용하여 부모 클래스의 생성자 호출하기
        class Parent1
        {
            //매개변수로 넘어온 값 출력
            public Parent1(string message) => Console.WriteLine(message);
        }

        //class Child1 : Parent1
        //{
        //    //매개변수로 넘어온 값 출력
        //    //public Child1(string message) : base(message);

        //}
        #endregion

        #region 생성자 상속하기
        public string Word { get; set; }
        #endregion
        static void Main(string[] args)
        {
            #region 상속의 기본예제
            var child = new Child();
            child.Foo();
            child.Bar();
            #endregion

            #region 부모 클래스 형식 변수에 자식 클래스의 개체 할당하기
            var web = new WebDeveloper();
            Console.WriteLine(web);

            var mobile = new MobileDeveloper();
            Console.WriteLine(mobile);

            #endregion

            #region 상속 관계 구현(is an)
            Vehicle vehicle = new Vehicle();

            Vehicle car = new Car();

            Vehicle airPlane = new Airplane();

            Console.WriteLine($"{vehicle},{car},{airPlane}");
            #endregion

            #region 클래스 상속을 사용한 부모의 protected 멤버에 접근하기
            //1 부모클래스의 인스턴스 생성
            ParentClass p = new ParentClass();
            Console.WriteLine(p.ToString());

            //2 자식 클래스의 인스턴스 생성
            ChildClass c = new ChildClass();
            //Print1()메서드는 protected로 설정되어있어 접근불가

            c.Print2(); //자식 클래스에 직접 구현한 기능
            #endregion

            #region base 키워드를 사용하여 부모 클래스의 생성자 호출하기
            
            #endregion
        }
    }
}
