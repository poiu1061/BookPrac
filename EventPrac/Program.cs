using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ButtonClass btn = new ButtonClass();

            btn.Click += Hi1;
            btn.Click += Hi2;

            btn.OnClick();
        }

        static void Hi1() => Console.WriteLine("C#");
        static void Hi2() => Console.WriteLine(".NET");
    }

    public class ButtonClass
    {
        public delegate void EventHandler();

        public event EventHandler Click;

        public void OnClick()
        {
            if(Click != null)
            {
                Click();
            }
        }
    }

   
}
