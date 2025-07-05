using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program13
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number = 10;
            Console.WriteLine("23SOECE11079:-Solanki Himani");
            Console.Write("{0} {1} ", n1, n2);

            for (i = 2; i <= number; ++i)
            {
                n3 = n1 + n2;
                Console.Write("{0} ", n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
