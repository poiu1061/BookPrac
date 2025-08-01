using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region try catch Exception e
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region formatException
            string inputNumber = "3.14";
            int number = 0;

            try
            {
                number = Convert.ToInt32(inputNumber);
                Console.WriteLine($"입력한 값 : {number}");
            }
            catch(FormatException fe)
            {
                Console.WriteLine($"에러 발생 : { fe.Message}");
                Console.WriteLine($"{inputNumber}는 정수여야 합니다.");
            }
            #endregion
        }
    }
}
