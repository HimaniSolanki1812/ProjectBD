using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array2
    {
        public static void Main()
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);

            Console.WriteLine("Array in ascending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("23SOECE11079: Solanki_Himani");
        }
    }
}
