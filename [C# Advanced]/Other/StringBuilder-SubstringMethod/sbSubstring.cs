using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class sbSubstring
    {
        static public void Main(string[] args)
        {
           StringBuilder alphabet = new StringBuilder();

            for (int i = 'a'; i < 'z'; i++)
            {
                alphabet.Append((char) i); 
            }

            string firstTen = alphabet.Substring(0, 10);

            Console.WriteLine(firstTen);
            
        }
    }
}
