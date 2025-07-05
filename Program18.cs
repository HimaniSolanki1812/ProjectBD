using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program18
    {
        public static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(k++ + " ");
                Console.WriteLine();
            }
            Console.WriteLine("23SOECE11079:Solanki Himani");
        }
    }
}
