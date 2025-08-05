using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array1
    {
        static void Main()
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Element {i + 1}: {arr[i]}");
                
            }
            Console.WriteLine("23SOECE11079: Solanki Himani");
        }
    }
}
