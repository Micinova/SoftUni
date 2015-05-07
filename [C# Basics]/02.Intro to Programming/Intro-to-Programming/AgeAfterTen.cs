using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AgeAfterTen
    {
        static void Main(string[] args)
        {



            Console.Write("Enter your birth date(yyyy, mm, dd): ");
            DateTime BirthDay = DateTime.Parse(Console.ReadLine());
            int age = (int)((DateTime.Now - BirthDay).TotalDays / 365.242199);
            Console.WriteLine("You are " + age + " year(s) old");
            Console.WriteLine("After ten years you will be at the age of " + (age + 10));
        }
    }
}
