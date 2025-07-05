using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program6
    {
        public static void Main(string[] args)
        {
            int a, b, c, result;
            string str;

            Console.Write("Enter Number 1: ");
            str = Console.ReadLine(); // Missing
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            str = Console.ReadLine(); // Missing
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str); // Missing

            result = Sum(a, b, c); // Call Sum method

            Console.WriteLine("Sum : {0}", result); // Missing
            Console.WriteLine("23SOECE11079  -- Solanki Himani");

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

    }
}
