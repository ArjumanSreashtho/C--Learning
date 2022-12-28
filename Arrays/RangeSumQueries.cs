using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Arrays
{
    internal class RangeSumQueries
    {
        public static void Run()
        {
            Console.Write("Enter the total number of elements: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] cumSum = CalculateCumSum(arr, num);
            CalculateQueries(cumSum, num);
        }

        private static bool CheckRange(int left, int right, int totalElements)
        {
            if (left < 0 || right >= totalElements || left > right)
                return false;
            return true;
        }

        private static void CalculateQueries(int[] cumSum, int num)
        {
            Console.Write("Enter the total number of queries: ");
            int query = Convert.ToInt32(Console.ReadLine());
            while (query-- > 0)
            {
                Console.WriteLine($"Enter the left and right query between (0 - {num - 1})");
                int left = Convert.ToInt32(Console.ReadLine());
                int right = Convert.ToInt32(Console.ReadLine());
                if (CheckRange(left, right, num))
                {
                    Console.WriteLine($"Total sum between {left} and {right} is: {cumSum[right] - (left == 0 ? 0 : cumSum[left - 1])}");
                    continue;
                }
                Console.WriteLine("Invalid range!!");
            }
        }

        private static int[] CalculateCumSum(int[] arr, int len)
        {
            
            int[] cumSum = new int[len];
            cumSum[0] = arr[0];
            for(int i = 1; i < len; i++)
            {
                cumSum[i] = arr[i] + cumSum[i-1];
            }
            return cumSum;
        }
    }
}
