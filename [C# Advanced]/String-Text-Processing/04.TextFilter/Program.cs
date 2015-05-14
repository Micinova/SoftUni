using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] banned = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder bannedText = new StringBuilder(Console.ReadLine());
            string[] bannedAsAsterisks = new string[banned.Count()];

            for (int i = 0; i < banned.Count(); i++)
            {
                bannedAsAsterisks[i] = new string('*', banned[i].Length);
                bannedText.Replace(banned[i], bannedAsAsterisks[i]);
            }
            Console.WriteLine(bannedText);
        }
    }
}
