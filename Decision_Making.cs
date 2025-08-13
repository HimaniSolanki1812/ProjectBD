using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Decision_Making
    {
        
        static void Main(string[] args)
        {
            int a = 100;

            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                Console.WriteLine("a is not less than 20"); // Missing statement-1
            }

            Console.WriteLine("value of a is : {0}", a); // Missing statement-2
            Console.WriteLine("23SOECE11079 : Solanki_Himani");

            Console.ReadLine();
        }
    }
}
