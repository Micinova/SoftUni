using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVar
{
    class BoolVar
    {
        static void Main(string[] args)
        {
            bool isFemale = true;
            Console.Write("Are u a female? (Yes/No):");
            string answer = Console.ReadLine();
            if (answer == "Yes")
            {
                isFemale = true;
                Console.WriteLine(isFemale);
            }
            else if (answer == "No")
            {
                isFemale = false;
                Console.WriteLine(isFemale);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
