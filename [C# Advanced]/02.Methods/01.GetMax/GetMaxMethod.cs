using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.GetMax
{
    class GetMaxMethod
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            
            int second = int.Parse(Console.ReadLine());

            int max = GetMax(first, second);
            Console.WriteLine(max);
        }

        public static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
