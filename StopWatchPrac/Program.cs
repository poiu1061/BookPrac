using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace StopWatchPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            LongTimeProcess();
            timer.Stop();

            //밀리초 단위로 표시
            Console.WriteLine(" 경과 시간 : {0}밀리초", timer.Elapsed.TotalMilliseconds);

            //초 단위로 표시
            Console.WriteLine(" 경과 시간 : {0}초", timer.Elapsed.Seconds);
        }

        static void LongTimeProcess()
        {
            Thread.Sleep(3000);
        }
    }
}
