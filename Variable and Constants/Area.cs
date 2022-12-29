using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Variable_and_Constants
{
    internal class Area
    {
        private const float PI = 3.1416f;
        public static void Run()
        {
            Console.Write("Please input the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = PI* radius *radius;
            Console.WriteLine($"Area of the circle is: {area.ToString("0.00")}");
        }

    }
}
