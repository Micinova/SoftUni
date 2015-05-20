using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncrSeq
{
    internal class LongestIncrSeq
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
           
            int difference = 1;
            int firstMember = 0;
            int lastMember = 0;
            int sequenceCounter = 1;
            int maxSeqCount = 1;

            int previousMember = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - previousMember == difference)
                {
                    sequenceCounter++;
                    difference++;

                    if (sequenceCounter > maxSeqCount)
                    {
                        maxSeqCount = sequenceCounter;
                        firstMember = previousMember;
                        lastMember = numbers[i];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    previousMember = numbers[i];
                    difference = 1;
                }
            }
            if (maxSeqCount != 1)
            {
                Console.WriteLine("Longest increasing sequence members:");
                for (int i = firstMember; i <= lastMember; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no icreasing sequence members!");
            }
        }
    }



}