using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program5
    {
        public static void Main(string[] args)
        {
            int n, fact = 1; // Declare n and fact, initialize fact to 1
            Console.WriteLine("Enter Number : "); // Prompt user
            string str = Console.ReadLine(); // Read input as string
            n = Convert.ToInt32(str); // Convert to int

            for (int i = 1; i <= n; i++) // Loop from 1 to n
            {
                fact = fact * i; // Multiply fact by i
            }

            Console.WriteLine("Factorial : {0}", fact); // Print factorial
            Console.WriteLine("23SOECE11079:-Solanki Himani");


            Console.Read(); // Pause output
        }
    }
}
