using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    internal class Program
    {

        static void Print(string name, int age) => Console.WriteLine($"{name}은 {age}입니다");
        static void Print(Member member)=> Console.WriteLine($"이름 : {member.Name}, 나이: {member.Age}");
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 21;
          

            Point point;
            point.x = 100;
            point.y = 200;
            Console.WriteLine($"X : {point.x}, Y : {point.y}");

            Product product;
            product.Id = 1;
            product.Title = "좋은책";
            product.Price = 1000M;
            Console.WriteLine($"제품아이디 : {product.Id}, 제품명 : {product.Title}, 제품 가격 : {product.Price}");

            BusinessCard biz;
            biz.Name = "홍길동";
            biz.Age = 17;
            Print(biz.Name, biz.Age);

            //구조체 배열을 사용하여 데이터 대입및 출력
            BusinessCard[] names = new BusinessCard[2];
            names[0].Name = "백두산"; names[0].Age = 102;
            names[1].Name = "임꺽정"; names[1].Age = 31;
            for(int i = 0; i<2; i++)
            {
                Print(names[i].Name, names[i].Age);
            }

            Print(name, age);

            //함수의 매개변수에 구조체 사용하기
            Member m;
            m.Name = "백두산";
            m.Age = 100;
            Print(m);

            //중첩구조체 사용하기
            Student student1 = new Student();
            student1.Name = "철수";
            student1.StudentsAddress = new Address { Street = "123번길", City = "서울", ZipCode = "12345" };

            Console.WriteLine("이름 :" + student1.Name);
            Console.WriteLine("주소 :");
            Console.WriteLine("      거리 : " +student1.StudentsAddress.Street);
            Console.WriteLine("      도시 : " + student1.StudentsAddress.City);
            Console.WriteLine("      우편번호 : " + student1.StudentsAddress.ZipCode);

            Console.WriteLine(DateTime.Now.Year);

        }


        struct Product
        {
            public int Id;
            public string Title;
            public decimal Price;
        }

        struct Point
        {
            public int x;
            public int y;
        }

        struct BusinessCard
        {
            public string Name;
            public int Age;
        }

        struct Member
        {
            public string Name;
            public int Age;
        }
        
        struct Address
        {
            public string Street;
            public string City;
            public string ZipCode;
        }

        struct Student
        {
            public string Name;
            public Address StudentsAddress;
        }
    }
}
