using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array6
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine("23SOECE11079: Solanki_Himani");
        }
    }
}
