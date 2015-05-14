using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Length < 20)
            {
                Console.WriteLine(s.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine("a regular expression");
            }
        }
    }
}
