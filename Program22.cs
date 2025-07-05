using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program22
    {
        public static void Main(string[] args)
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine("23SOECE11079  -- Solanki Himani");
        }
    }
}
