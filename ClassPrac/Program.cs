using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassPrac
{

   

    #region 부분클래스로 나누어 메서드와 속성을 나누어 관리
    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name} : {Age}");
    }
    #endregion


    #region 함수형 프로그래밍 스타일: 메서드 체이닝
    class Point
    {
        public readonly int x;
        public readonly int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point Moveby(int dx, int dy)
        {
            return new Point(x + dx, y + dy);
        }

    }


    #endregion

    #region immutable(불변형식)
    public class Circle
    {
        public int Radius { get; private set; } = 0;
    }
    #endregion

   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 부분클래스로 나누어 메서드와 속성을 나누어 관리
            Person person = new Person();

            person.Name = "C#";
            person.Age = 25;

            person.Print();
            #endregion

            #region 함수형 프로그래밍 스타일: 메서드 체이닝
            var p = (new Point(0, 0)).Moveby(10, 10).Moveby(20, 20).Moveby(30, 30);
            #endregion

        }
    }
}
