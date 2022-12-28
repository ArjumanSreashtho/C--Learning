using BasicPractice.Variable_and_Constants;
using BasicPractice.Arrays;
using BasicPractice.Strings;
using BasicPractice.Loops;
using BasicPractice.Decision_Making;

namespace BasicPractice 
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Variable and Constant
             */

            //VarAndConst.AreaOfCircle();

            /*
             * Decision Making
             */
            LeapYear.Run();

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
        }

        
    }
}