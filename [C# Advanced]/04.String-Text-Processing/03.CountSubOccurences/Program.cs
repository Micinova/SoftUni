using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountSubOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine().ToLower();


            int count = 0;
            int i = 0;

            while ((i = text.IndexOf(subStr, i)) != -1)
            {
                i++;
                count++;
            }

            Console.WriteLine(count);

        }
    }
}
