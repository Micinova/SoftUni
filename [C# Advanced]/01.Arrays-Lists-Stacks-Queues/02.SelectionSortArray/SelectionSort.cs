using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SelectionSortArray
{
    internal class SelectionSort
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                bool check = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int temp = 0;
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        check = true;
                    }
                }
                if (!check)
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
