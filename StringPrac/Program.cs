using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string Time
            //string 으로 걸린시간
            DateTime start = DateTime.Now;

            string msg = "";
            for(int i = 0; i<10000; i++)
            {
                msg += "안녕하세요";
            }

            DateTime end = DateTime.Now;
            double exec = (end - start).TotalMilliseconds;
            Console.WriteLine(exec);
            #endregion

            #region stringBuilder Time
            DateTime start2 = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i <10000; i++)
            {
                sb.Append("안녕하세요");
            }
            DateTime end2 = DateTime.Now;
            double exec2 = (end2 - start2).TotalMilliseconds;
            Console.WriteLine(exec2);
            #endregion



        }
    }
}
