using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPrac
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Note note = new Note(); 
        //    note.VisitCount();

        //    Console.WriteLine(note.add(3, 5));

        //    ShareAndInstance.StaticMember();

        //    ShareAndInstance obj = new ShareAndInstance();
        //    obj.InstanceMember();

        //    Class2.Hi();

        //    Class2 c2 = new Class2();
        //    c2.Hello();
        //}

    }
    class Note
    {
        public void VisitCount()
        {
            Console.WriteLine("오늘의 접속자는 1234명입니다");
        }


        public int add(int x,int y) => x+y;
    }

    class ShareAndInstance
    {
        public static void StaticMember() => Console.WriteLine("[1] Static Member");
        public  void InstanceMember() => Console.WriteLine("[2] Instance Member");

    }
}
