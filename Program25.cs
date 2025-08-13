using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program25
    {
        static int matSearch(int[,] mat, int N, int M, int X)
        {
            int i = 0, j = M - 1;
            while (i < N && j >= 0)
            {
                if (mat[i, j] == X) return 1;
                else if (mat[i, j] > X) j--;
                else i++;
            }
            return 0;
        }
        static void Main()
        {
            int[,] mat = {
            {3, 30, 38},
            {44, 52, 54},
            {57, 60, 69}
        };
            Console.WriteLine(matSearch(mat, 3, 3, 62)); // Output: 0
            Console.WriteLine(matSearch(mat, 3, 3, 52));// Output: 1
            Console.WriteLine("23SOECE11079: Solanki_Himani");
        }
    }
}
