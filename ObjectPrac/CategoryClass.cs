using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPrac
{
    internal class CategoryClass
    {
        public void Print(int i) => Console.WriteLine($"카테고리 {i}");
    }

    class ClassArray
    {
        static void Main()
        {
            CategoryClass[] categories = new CategoryClass[3];

            categories[0] = new CategoryClass();
            categories[1] = new CategoryClass();
            categories[2] = new CategoryClass();

            for(int i =0; i<categories.Length; i++)
            {
                categories[i].Print(i);
            }

           //IEnumerable<int> data = Enumerable.Range(1, 100);
           //var result = data.Skip(20).Take(20).Where(num => num % 2 == 1).OrderBy(num => num);
           //foreach(int a in result)
           //{
           //     Console.Write(a + " ");
           //}
        }
    }
}
