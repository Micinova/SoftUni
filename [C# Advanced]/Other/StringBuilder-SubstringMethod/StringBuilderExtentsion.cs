using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
   public static class StringBuilderExtentsion
    {
       public static string Substring(this StringBuilder sb, int startIndex, int count)
       {

           StringBuilder das = new StringBuilder();
           for (int i = sb[startIndex]; i < sb[count]; i++)
           {
               das.Append((char)i);
               
           }
           //string result = das.ToString();
           //Console.WriteLine(result);
           return das.ToString();
       }
    }
}
