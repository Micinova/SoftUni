using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SeqEqualStrings
{
    class SeqEqualStrings
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split().ToArray();
            

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i == sequence.Length-1)
                {
                    Console.WriteLine(sequence[i]);
                }
                
                else if (sequence[i] == sequence[i + 1])
                {
                    List<string> s = new List<string>();
                    s.Add(sequence[i]);
                    //s.Add(sequence[i+1]);
                    Console.Write(string.Join(" ", s)+" ");
                    
                }
                else
                {
                    Console.WriteLine(sequence[i]);
                }
            }
        }
    }
}
