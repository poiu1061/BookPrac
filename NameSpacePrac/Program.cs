using Bar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Korea.Seoul;
using In = Korea.Incheon;

namespace Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("[1] Foo 네임스페이스의 Car클래스 호출");
    }
}

namespace Bar
{
    //public class Car
    //{
    //    public void Go() => Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
    //}
}


namespace Korea
{
    namespace Seoul
    {
        public class Car
        {
            public void Run() => Console.WriteLine("서울 자동차가 달립니다.");
        }
    }

    namespace Incheon
    {
        public class Car
        {
            public void Run() => Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}



class NamespaceNote
{
    static void Main()
    {
        //Foo.Car fooCar = new Foo.Car();
        //fooCar.Go();
        //Bar.Car barCar = new Bar.Car();
        //barCar.Go();

        Korea.Seoul.Car s = new Korea.Seoul.Car();
        s.Run();
        Korea.Incheon.Car i = new Korea.Incheon.Car();
        i.Run();

        Car Seoul = new Car();
        Seoul.Run();

        In.Car ic = new In.Car();
        ic.Run();

    }
}



