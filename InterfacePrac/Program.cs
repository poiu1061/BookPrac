using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
namespace InterfacePrac
{
    #region 인터페이스로 특정 멤버가 반드시 구현되어야 함을 보증하기
    interface ICar
    {
        void Go();
    }

    class Car : ICar
    {
        public void Go() => Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야 합니다.");
    }

    #endregion

    #region 인터페이스 형식 개체에 인스턴스 담기
    public interface IRespository
    {
        void Get();
    }

    public class Repository : IRespository
    {
        public void Get()
        {
            Console.WriteLine("Get()메서드를 구현해야합니다");
        }
    }
    #endregion

    #region 생성잗의 매개변수에 인터페이스 사용하기
    interface IBattery
    {
        string GetName();
    }

    class Good : IBattery
    {
        public string GetName() => "Good";
    }

    class Bad : IBattery
    {
        public string GetName() => "Bad";
    }

    class Car1
    {
        private IBattery _battery;
        public Car1(IBattery battery)
        {
            _battery = battery; //넘어온 개체가 _battery 필드에 저장
        }
        public void Run() => Console.WriteLine("{0} 배터리를 장착한 자동차가 달립니다.", _battery.GetName());
    }
    #endregion

    #region 인터페이스를 사용한 다중 상속 구현하기
    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다");
    }
    #endregion

    #region 명시적인 인터페이스 구현하기
    interface IPuppy
    {
        void Eat();
    }

    interface ICat
    {
        void Eat();
    }

    class Pet : IPuppy, ICat
    {
        void IPuppy.Eat() => Console.WriteLine("Dog Eat"); //1 명시적으로 IPuppy 지정
        void ICat.Eat() => Console.WriteLine("Cat Eat");   //2 명시적으로  ICat 지정
    }
    #endregion

    #region IDisposable 인터페이스 사용하기
    public class Toilet : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("[3]닫기");
        }
    }
    #endregion

    #region 인터페이스를 사용하여 멤버 이름 강제로 적용시키기
    //인터페이스: 설계 : Run()이라는 단어 설계(명시)
    public interface IStandard { void Run(); }

    //추상클래스 : 설계 + 구현
    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }

    //3 분할클래스
    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    //4 봉인클래스

    public sealed class Car2 : MyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }

    //5 다음코드는 에러(봉인클래스는 상속 불가)
    //public class SelfCar: Car2 {}
    #endregion

    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region 인터페이스로 특정 멤버가 반드시 구현되어야 함을 보증하기
            var car = new Car();
            car.Go();
            #endregion

            #region 인터페이스 형식 개체에 인스턴스 담기
            IRespository respository = new Repository();
            respository.Get();
            #endregion

            #region 생성잗의 매개변수에 인터페이스 사용하기
            //a 넘겨주는 개체에 따라 배터리 이름이 다르게 표시
            var good = new Car1(new Good()); good.Run();
            new Car1(new Bad()).Run();
            #endregion

            #region 인터페이스를 사용한 다중 상속 구현하기
            Dog dog = new Dog();
            dog.Eat();
            dog.Yelp();
            #endregion

            #region 명시적인 인터페이스 구현하기
            Pet pet = new Pet();
            ((IPuppy)pet).Eat(); //pet 개체를 IPuppy 형식으로 변환
            ((ICat)pet).Eat();   //pet 개체를 ICat 형식으로 변환

            IPuppy puppy= new Pet();
            puppy.Eat();
            ICat cat = new Pet();
            cat.Eat();
            #endregion

            #region .net에 내장된 IEnumerator 인터페이스 사용하기
            string[] names = { "닷넷코리아", "비주얼아카데미" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            //IEnumerator 인터페이스를 사용한 데이터 출럭: foreach문과 동일
            IEnumerator list = names.GetEnumerator();

            while (list.MoveNext())
            {
                Console.WriteLine(list.Current);
            }
            #endregion

            #region IDisposable 인터페이스 사용하기
            Console.WriteLine("[1] 열기");
            using (var t = new Toilet())
            {
                Console.WriteLine("[2] 사용");
            }
            #endregion

            #region 인터페이스를 사용하여 멤버 이름 강제로 적용시키기
            Car2 cla = new Car2();
            cla.Run(); cla.Left(); cla.Right(); cla.Back();
            #endregion
        }
    }
}
