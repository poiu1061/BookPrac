using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 기본 속성 다루기
            Developer developer = new Developer();

            developer.name = "유지훈";         //set
            Console.WriteLine(developer.name); //get

            var person = new Person();
            person.Name="Gilbut";
            Console.WriteLine(person.Name);
            Car c1 = new Car();
            c1.Name = "람보르기니";
            Console.WriteLine(c1.Name);

            Car c2 = new Car();
            c2.Name = "제네시스"; c2.Color = "Red";
            Console.WriteLine("{0}, {1}",c2.Name,c2.Color);

            Person person1 = new Person();
            Console.WriteLine($"{person.Id} , {person1.Name}");


            Exam exam = new Exam();
            exam.Id = 1;
            exam.Title = "중간고사";

            Console.WriteLine($"{exam.Id}-{exam.Title}");
            #endregion


            
            #region 모든 속성 다뤄보기
            
            //set과 get 메서드 사용
            Car2 car = new Car2();
            car.SetColor("Red");
            Console.WriteLine(car.GetColor());

            //속성을 사용
            Car2 whiteCar = new Car2();
            whiteCar.Color = "White";
            Console.WriteLine(whiteCar.Color);

            //읽기 전용 속성
            Car2 k = new Car2();
            Console.WriteLine(k.Make);

            //쓰기 전용 속성
            Car2 car2 = new Car2();
            car2.Type = "중형";

            //축약형 속성
            Car2 myCar = new Car2();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);


            #endregion
        }

        class Developer
        {
            public string name { set; get; }
        }

        class Car
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Color { get; set; }
        }

        class Person
        {
            public Guid Id { set; get; } = Guid.NewGuid();
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        class Exam
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }

        #region 속성의 여러가지 유형
        public class Car2
        {
            private string color;//필드
            public Car2()//생성자
            {
                this.color = "Black";
            }

            //메서드로 외부에 공개
            public void SetColor(string color)
            {
                this.color = color;
            }

            public string GetColor()
            {
                return color;
            }

            //속성
            public string Color
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }

            //읽기 속성 전용
            public string Make
            {
                get
                {
                    return "한국 자동차";
                }
            }

            //ㅆ,기 전용 속성
            private string _Type;
            public string Type
            {
                set
                {
                    _Type = value;
                }
            }

            //축약형 속성
            public string Name { get; set; }

        }
        #endregion
    }
}
