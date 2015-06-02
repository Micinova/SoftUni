using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string input = Console.ReadLine();
            int[] shotParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int i = 0;
            int radius = shotParams[2];
            int n = dimensions[0];
            int m = dimensions[1];
            char[,] matrix = new char[dimensions[0], dimensions[1]];

            //filling matrix with chars from string
            for (int rows = matrix.GetLength(0)-1; rows > -1; rows--)
            {
                var cols = 0;
                for (cols = matrix.GetLength(1)-1; cols > -1; cols--, i++)
                {
                    
                    if (i == input.Length)
                    {
                        i = 0;
                    }
                    matrix[rows, cols] = input[i];
                    if (rows == 0 && cols == 0)
                    {
                        break;
                    }
                }
                cols = 0;
                rows--;
                if (rows < 0 && cols == 0)
                {
                    break;
                }
                
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++, i++)
                {
                    if (rows == 0 && cols == 0)
                    {
                        break;
                    }
                    if (i == input.Length)
                    {
                        i = 0;
                    }
                    matrix[rows, j] = input[i];
                }   
            }

            char shot = matrix[shotParams[0],shotParams[1]];
            double d = shotParams[0];
            double g = shotParams[1];



            for (int j = 0; j <= radius; j++)
            {
               
                    int row = shotParams[0];
                    int col = shotParams[1];
                if (row + j < matrix.GetLength(0) && col + j < matrix.GetLength(1))
                {
                    matrix[row, col + j] = ' ';
                    matrix[row + j, col] = ' ';
                    matrix[row, col - j] = ' ';
                    matrix[row - j, col] = ' ';
                    matrix[row + j / 2, col + j / 2] = ' ';
                    matrix[row - j / 2, col - j / 2] = ' ';
                    matrix[row - j / 2, col + j / 2] = ' ';
                    matrix[row + j / 2, col - j / 2] = ' ';
                }
                else
                {
                    continue;
                }
                    
                
                    
                
               
            }

           
            FallText(n, m, matrix);


            ////printing matrix
            for (int r = 0; r < dimensions[0]; r++)
            {
                for (int c = 0; c < dimensions[1]; c++)
                {
                    Console.Write("{0}", matrix[r, c]);
                }
                Console.WriteLine();
            }

        }
        private static void FallText(int n, int m, char[,] matrix)
        {
            bool fallen = false;
            do
            {
                fallen = false;
                for (int row = 0; row < n - 1; row++)
                {
                    for (int col = 0; col < m; col++)
                    {
                        if (matrix[row, col] != ' ' && matrix[row + 1, col] == ' ')
                        {
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                            fallen = true;
                        }
                    }
                }
            } while (fallen);
        }
    }

}
