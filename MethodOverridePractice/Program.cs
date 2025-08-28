using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridePractice
{
    internal class Program
    {
        public class ParentClass
        {
            public virtual void Hi1() => Console.WriteLine("기본 : 안녕하세요");
            public void Hi2() => Console.WriteLine("기본 : 반갑습니다");
            public void Hi3() => Console.WriteLine("기본 : 또 만나요");
        }

        public class ChildClass : ParentClass
        {
            public override void Hi1() => Console.WriteLine("파생 : 안녕하세요.");

        }

        class Parent
        {
            public void Say() => Console.WriteLine("부모가 말하다");
            public void Hi() => Console.WriteLine("부모가 인사하다");
            public virtual void Walk() => Console.WriteLine("부모가 걷다.");
        }

        class Child : Parent
        {
            //내가 새롭게 정의하여 사용
            public void Say() => Console.WriteLine("자식이 말하다");

            //새롭게 정의 : 오버라이드
            public new void Hi() => Console.WriteLine("자식이 인사하다");

            //새롭게 정의 : 오버라이드 : 재정의
            public override void Walk() => Console.WriteLine("자식이 걷다");
        }
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();
            child.Hi1(); //virtual -> override
            child.Hi2(); //X->NEW
            child.Hi3(); // X //BASE

            Child baby = new Child();
            baby.Say(); //자식이 예의가 없다
            baby.Hi();  //자식이 예의 바르다.
            baby.Walk();//부모가 관대하다`
        }
    }
}
