using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region stack<>활용
            Stack<int> stack = new Stack<int>();
            stack.Push(2160);
            int height = stack.Pop();
            Console.WriteLine(height);
            #endregion

            #region List<>활용
            List<int> lstNumbers = new List<int>();
            lstNumbers.Add(30);
            lstNumbers.Add(40);
            for(int i = 0; i<lstNumbers.Count; i++)
            {
                Console.WriteLine(lstNumbers[i]);
            }


            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            for(int i = 0; i < colors.Count; i++)
            {
                Console.Write($"{colors[i]}\t");
            }

            Console.WriteLine();

            foreach(var color in colors)
            {
                Console.Write($"{color}\t");

            }

            #endregion

            #region Enumerable<> 활용
            //Enumerable.Range() 범위를 지정하여 정수 컬렉션 생성
            //Ex) Enumrable.Range(1,10) 1에서 10까지의 정수 컬렉션 생성

            //Enumerable.repeat() 
            //Ex)Enumerable.repeat(100,5) 100을 5개 생성

            Console.WriteLine();

            var numbers = Enumerable.Range(1, 5);
            foreach (var n in numbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();

            var sameNumbers = Enumerable.Repeat(-1, 5);
            foreach (var n in sameNumbers)
                Console.Write("{0}\t", n);
            Console.WriteLine();
            #endregion

            #region dictionary<> 활용하기
            var data = new Dictionary<string, string>();

            data.Add("cs", "C#");
            data.Add("aspx", "ASP.NET");

            data.Remove("aspx");
            data["cshtml"] = "ASP.NET MVC";

            try
            {
                data.Add("cs", "CSharp");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //출력예제1
            foreach(KeyValuePair<string,string> item in data)
            {
                Console.WriteLine("{0}은 {1}의 확장자 입니다", item.Key, item.Value);
            }

            //출력예제2
            foreach(var item in data)
            {
                Console.WriteLine("{0}은(는) {1}의 확장자 입니다.",item.Key, item.Value);
            }
            #endregion

        
        }
    }
}
