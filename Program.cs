using BasicPractice.Variable_and_Constants;
using BasicPractice.Arrays;
using BasicPractice.Strings;
using BasicPractice.Loops;
using BasicPractice.Decision_Making;
using BasicPractice.Structure;

namespace BasicPractice 
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Variable and Constant
             */
            /*
             * Input the radius of a circle and output the area of that circle (show 2 digit after decimal point)
             * 
             * Input: 5
             * Output: 78.54
             */

            //Area.Run();

            /*
             * Decision Making
             */
            /*
             * Input a year and check if that year is a leap year or not
             * 
             * Input: 1996
             * Output: 1996 is a leap year
             * 
             * Input: 1700
             * Output: 1700 is not a leap year
             */
            //LeapYear.Run();

            /*
             * Loops
             */
            /*
             * You will be given a positive integer number which has even number of digits
             * check whether sum of left side digits is equal to the sum of right side of digits
             * 
             * Input: 1259
             * Output: False
             * 
             * Input: 6455
             * Output: True
             */
            //DigitSum.Run();

            /*
             * Arrays
             * 
             * For a given number N. Take N numbers as input and Q number as queries
             * For each query take a range A and B (0 <= A, B < N)
             * Calculate sum between range A and B
             * 
             * Input:
             * 5
             * 
             * 1
             * 2 
             * 3
             * 4
             * 5
             * 
             * 2
             * 
             * 0 4
             * Total sum between (0-4) is 15
             */

            //RangeSumQueries.Run();

            /*
             * Strings
             */
            /*
             * Input a line. Count the number of characters in line.
             * 
             * Input: abcc1a321
             * Output: 1 = 2
             *         2 = 1
             *         3 = 1
             *         a = 2
             *         b = 1
             *         c = 2
             */
            //CharacterCounter.Run();

            /*
             * Structure
             */
            /*
             * Input a line. Count the number of characters in line.
             * Note: Print the characters sequentially, how these are appeared in the original input
             * 
             * Input: abcc1a321
             * Output: a = 2
             *         b = 1
             *         c = 2
             *         1 = 2
             *         3 = 1
             *         2 = 1
             */
            //CharacterCounterMod.Run();
        }

        
    }
}