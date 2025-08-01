using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQMethodPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            int sum = numbers.Sum();
            int count = numbers.Count();
            int max = numbers.Max();
            int min = numbers.Min();
            double avg = numbers.Average();

            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(avg);

            #region 화살표 메서드와 람다식으로 조건처리
            Func<int, bool> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(2));
            Console.WriteLine(isEven(3));

            Func<int, int, int> com = (a, b) => (a + b);
            Console.WriteLine(com(5, 7));

            Func<int, int, double> div = (a, b) => (double)a / b;
            Console.WriteLine(div(7, 5));

            Func<int, int, int> mul = (a, b) => a * b;
            Console.WriteLine(mul(8, 9));
            #endregion

            #region Where()메서드 활용해보기
            var nums = new List<int> { 1, 2, 3, 7, 9, 12, 16, 18 };
            nums.Where(number => number % 2 == 0).Sum();

            Console.WriteLine(nums.Where(number => number % 2 == 0).Sum());

            int[] arr = { 1, 2, 3, 4, 5 };
            var q = arr.Where(num => num % 2 == 1);

            foreach(var n in q)
            {
                Console.Write(n+" ");
            }

            //=================================
            int[] arr1 = new int[50];
            Random r = new Random();

            for(int i =0; i<50; i++)
            {
                bool flag = false;
                int num = r.Next(1, 100);
                for(int j = 0; j<i; j++)
                {
                    if (arr1[j] == num)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    i--;
                }
                else
                {
                    arr1[i] = num;
                }
            }

            var s = arr1.Where(su => su % 2 == 0);

            foreach(var su in s)
            {
                Console.Write(su + " ");    
            }
            Console.WriteLine(s.Sum());
            #endregion

            #region Where()메서드 확장 기능 활용해보기
            int[] sus = { 1, 2, 3, 4, 5 };

            var numbs = sus.Where(it => it % 2 == 1 && it > 3);

            foreach(var nb in numbs)
            {
                Console.WriteLine(nb);
            }
            #endregion

            #region Where()사용하지 않고 조건처리
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln => bln ==true));
            Console.WriteLine(blns.Count(bln => bln ==false));
            #endregion

            #region All()과 Any()메서드 활용해보기
            //All()은 배열안의 값들이 전부 조건과 일치해야 true를 반환 조건식의  and와 같음
            //Any()는 배열안의 값들이 일부만 조건과 일치해도 true를 반환 조건식의 or와 같음
            bool[] completes = { true, true, true };
            bool[] complete = { true, false, true };

            Console.WriteLine(completes.All(c => c == true));
            Console.WriteLine(complete.Any(c => c == false));

            string input = "Hello";
            bool Alluppercase = input.All(char.IsUpper);
            bool Anyuppercase = input.Any(char.IsUpper);
            Console.WriteLine(Alluppercase);
            Console.WriteLine(Anyuppercase);
            #endregion

            #region Take() 와 Skip()활용해보기
            var data = Enumerable.Range(0,100);
            data.Take(5);
            data.Where(x => x % 2 == 0);

            foreach(var item in data.Where(x => x % 2 == 0).Skip(10).Take(10))
            {
                Console.WriteLine(item); 
            }

            var data1 = Enumerable.Repeat(2, 5);
            var no = data1.Distinct();

            foreach(var item in no)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 데이터 정렬과 탐색
            string[] colors = { "Red", "Green", "Blue" };
            IEnumerable<string> t = colors.OrderBy(name => name);
            string[] arr2 = colors.OrderBy(name => name).Reverse().ToArray();
            string[] arr3 = colors.OrderByDescending(name => name).ToArray();

            foreach (string a in t)
            {
                Console.WriteLine(a);
            }

            foreach(string b in arr2)
            {
                Console.WriteLine(b);
            }

            foreach (string b in arr3)
            {
                Console.WriteLine(b);
            }
            #endregion

            #region 확장 메서드 체이닝(method Chaining)
            List<string> names = new List<string> { ".NET", "C#", "TypeScript"};

            var results = names.Where(name => name.Length > 2).OrderBy(n => n);
            foreach(string u in results)
            {
                Console.WriteLine(u);
            }

            #endregion
        }
    }
}

