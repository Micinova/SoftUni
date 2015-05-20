using System;
using System.Linq;

namespace _04.FirstLarger
{
    class FirstLarger4
    {
        static int[] arr;

        static bool GetFirstLarger(int checker)
        {
            bool firstLarger;
            if (checker == 0)
            {
                firstLarger = arr[checker] > arr[checker + 1];
            }
            else if (checker == arr.Length - 1)
            {
                firstLarger = arr[checker] > arr[checker - 1];
            }
            else
            {
                firstLarger = arr[checker] > arr[checker - 1] && arr[checker] > arr[checker + 1];
            }
            return firstLarger;
        }
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();
            bool isGreater = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (GetFirstLarger(i))
                {
                    Console.WriteLine("First Larger element is {0}", i);
                    isGreater = true;
                    break;
                }
            }
            if (!isGreater)
            {
                Console.WriteLine("-1");
            }
        }
    }
}