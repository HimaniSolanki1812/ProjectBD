using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array4
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            Console.WriteLine("Enter 5 elements for first array:");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Elements copied to second array:");
            foreach (int num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n23SOECE11079: Solanki Himani");
        }
       
    }
}
