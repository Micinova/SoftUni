using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = { ',', '?', '!', '.', ' ' };
            List<string> words = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries).Select(p => p).ToList();
            var result = new SortedSet<string>();
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                    result.Add(word);
            }
            Console.WriteLine(string.Join(", ", result));
        }

        private static bool IsPalindrome(string words)
        {
            if (words.Length == 1)
            {
                return true;
            }
            for (int i = 0; i < words.Length / 2; i++)
            {
                if (words[i] != words[words.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}

