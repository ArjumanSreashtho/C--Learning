using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Decision_Making
{
    internal class LeapYear
    {
        public static void Run()
        {
            Console.Write("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            Console.WriteLine("{0} is {1} a leap year.", year, isLeapYear ? null : "not");
        }
    }
}
