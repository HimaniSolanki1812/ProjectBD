using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array10
    {
        static void Main()
        {
            int[,] mat1 = new int[2, 2];
            int[,] mat2 = new int[2, 2];
            int[,] sum = new int[2, 2];

            Console.WriteLine("Enter elements for first 2x2 matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for second 2x2 matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Sum of the matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = mat1[i, j] + mat2[i, j];
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("23SOECE11079: Solanki_Himani");
        }
    }
}
