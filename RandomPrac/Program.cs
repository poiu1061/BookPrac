using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lotto
            Console.Write("이번주의 로또 : ");
            Random ran = new Random();

            int[] arr = new int[6];
            int temp = 0;
            for(int i = 0; i < 6; i++)
            {
                temp = ran.Next(45) + 1;
                bool flag = false;
                if(i>0 && i < 6)
                {
                    for(int j = 0; j<=i; j++)
                    {
                        if (arr[j] == temp)
                        {
                            flag = true;
                        }
                    }
                }
                if (flag)
                {
                    --i;
                }
                else
                {
                    arr[i] = temp;
                }
            }
            for(int i = 0; i < 6; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            #endregion

            #region 가위바위보
            int iRandom = 0;
            int iSelection = 0;
            string[] choice = { "가위", "바위", "보" };

            iRandom = (new Random()).Next(1, 4);

            Console.Write("1(가위), 2(바위),3(보) 입력 : _\b");
            iSelection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n 사용자 : {0}", choice[iSelection - 1]);
            Console.WriteLine(" 컴퓨터 : {0}\n", choice[iRandom-1]);

            if(iSelection == iRandom)
            {
                Console.WriteLine("비김");
            }
            else
            {
                switch (iSelection)
                {
                    case 1: Console.WriteLine((iRandom == 3) ? "승" : "패"); break;
                    case 2: Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
                    case 3: Console.WriteLine((iRandom == 2) ? "승" : "패"); break;

                }
            }
            #endregion

        }
    }
}
