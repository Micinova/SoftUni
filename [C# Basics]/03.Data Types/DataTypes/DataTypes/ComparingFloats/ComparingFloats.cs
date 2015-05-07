using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number a: ");
            string num1 = Console.ReadLine();
            double a = double.Parse(num1);

            Console.WriteLine("Number b: ");
            string num2 = Console.ReadLine();
            double b = double.Parse(num2);

            if (a - b > 0.000001 || b - a > 0.000001)
            {
                Console.WriteLine("false");
                
            }
            else if (a - b < 0.000001 || b - a < 0.000001)
            {
                Console.WriteLine("true");
            }



        }
    }
}
