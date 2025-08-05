using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array9
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter position to delete (1-5): ");
            int pos = Convert.ToInt32(Console.ReadLine()) - 1;

            if (pos < 0 || pos >= arr.Length)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                for (int i = pos; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                Console.WriteLine("Array after deletion:");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine("\n23SOECE11079: Solanki_Himani");

        }
    }
}
