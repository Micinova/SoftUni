using System;
using System.Linq;

namespace _03.LargerThanNeighbours
{
    class LargerNeighbours_3
    {
        static int[] arr;

        static bool CheckIfGreater(int checker)
        {
            bool isGreater;
            if (checker == 0)
            {
                isGreater = arr[checker] > arr[checker + 1];
            }
            else if (checker == arr.Length - 1)
            {
                isGreater = arr[checker] > arr[checker - 1];
            }
            else
            {
                isGreater = arr[checker] > arr[checker - 1] && arr[checker] > arr[checker + 1];
            }
            return isGreater;
        }
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(CheckIfGreater(i));
            }
        }
    }
}