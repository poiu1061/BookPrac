using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrac
{
    enum Animal { Mouse, Cow, Tiger }
    //열거형 값을 정수형이나 문자열로 사용
    enum Animal1 { Rabbit, Dragon, Snake }
    //열거형 인덱스 순서 변경하기
    enum Animal2 
    {
        Horse,//0
        Sheep = 5,//1 =>5
        Monkey,//2=>6
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Priority high = Priority.High;
            Priority normal = Priority.Normal;
            Priority low = Priority.Low;

            Console.WriteLine($"{high}, {normal} , {low}");

            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);
            if(animal == Animal.Tiger)
            {
                Console.WriteLine("호랑이");
            }

            //열거형 값을 정수형이나 문자열로 사용
            Animal1 animal1 = Animal1.Dragon;
            int num = (int)animal1;
            string str = animal1.ToString();
            Console.WriteLine($"Animal.Dragon : {num},{str}");

            //열거형 인덱스 수정
            Console.WriteLine((int)Animal2.Monkey);

            //열거형 switch 사용

            switch (animal)
            {
                case Animal.Mouse:
                    Console.WriteLine("쥐");
                    break;

                case Animal.Cow:
                    Console.WriteLine("소");
                    break;

                case Animal.Tiger:
                    Console.WriteLine("호랑이");
                    break;

            }
        }

        enum Priority
        {
            High,
            Normal,
            Low,
        }

       

    }
}
