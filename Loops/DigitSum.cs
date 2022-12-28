using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Loops
{
    internal class DigitSum
    {
        public static void Run()
        {
            Console.Write("Input a positive integer (even digits): ");
            int number = Convert.ToInt32(Console.ReadLine());
            int length = NumberLength(number);
            bool check = CheckSum(number, length);
            Console.WriteLine($"Output of the number is: {check}");
        }

        private static int NumberLength(int number)
        {
            int len = 0;
            while(number > 0)
            {
                number /= 10;
                len++;
            }
            return len;
        }

        private static bool CheckSum(int number, int length)
        {
            int leftSum = 0, rightSum = 0;
            for(int i = 0; i < length; i++)
            {
                if(i < length / 2)
                {
                    rightSum += number%10;
                }
                else
                {
                    leftSum += number%10;
                }
                number/= 10;
            }
            return leftSum == rightSum;

        }
    }
}
