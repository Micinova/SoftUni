using System;
using System.Threading;

namespace _01._2
{
    class Program
    {
        static void Main(string[] args)
        {
          CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int i, j, rows, cols;
            Console.WriteLine("Enter size of the two matrices: ");
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            Console.WriteLine("Enter values for first matrix:");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix:");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] b = new int[rows, cols];
            Console.WriteLine("Enter values for second matrix:");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The new matrix is:");
            int[,] c = new int[rows, cols];
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            
        }
    }
}