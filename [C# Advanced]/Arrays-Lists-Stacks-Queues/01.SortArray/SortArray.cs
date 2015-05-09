using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
