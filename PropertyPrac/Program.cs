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

            #region 개체를 초기화시키는 3가지방법
            //속성 사용
            Person2 pp = new Person2();
            pp.Name = "백두산";
            pp.Age = 100;

            //생성자 사용
            Person2 pp2 = new Person2("홍길동",21);

            //개체 이니셜라이저 사용
            Person2 pp3 = new Person2 { Name = "임꺽정", Age = 30 };

            #endregion

            #region 속성의 유효성검사 구현하기
            Car3 car3 = new Car3("자동차");
            Console.WriteLine(car3.name);

            //예외발생
            //Console.WriteLine((new Car3("").name));
            #endregion

            #region 속성값 초기화하기
            Pet pet = new Pet();
            pet.Weight = 50;
            pet.Feed(10);
            Console.WriteLine(pet.Weight);
            #endregion

            #region 속성 선언과 동시에 초기화하기
            var fish = new Fish();
            fish.Weight = 10;
            fish.Feed(15);
            Console.WriteLine(fish.Weight);
            #endregion

            #region 속성에서 ?와 ??연산자를 함께 사용하기
            // ?.(null  조건 연산자) ??(널 병합 연산자)
            //var people = new Person[] { new Person { Name = "RedPlus" }, null };

            //ProcessPeople(people);

            //void ProcessPeople(IEnumerable<Person> peopleArray)
            //{
            //    foreach (var person2 in peopleArray)
            //    {
            //        //1: ?.로 null을 확인하여 null이면 ?? 이후의 문자열로 초기화
            //        Console.WriteLine($"{person2?.Name ?? "아무개"}은(는)"
            //            +$"{person2?.A?.Street ?? "아무곳"}에 삽니다"
            //            );
            //    }
            //}
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

        #region 개체를 초기화하는 세가지 방법
        public class Person2
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person2()
            {

            }
            public Person2(string name, int age)
            {
                Name = name; Age = age;
            }
        }

       
            #endregion
    }
}
