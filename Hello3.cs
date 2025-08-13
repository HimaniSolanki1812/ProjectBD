using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Hello3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("You entered the following {0} command line arguments:", args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.WriteLine("23SOECE11079 : Solanki_Himani");

        }
    }
}
