using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array5
    {
        static void Main()
        {
            int[] arr = new int[5];
            int count = 0;

            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine($"Total duplicate elements: {count}");
            Console.WriteLine("23SOECE11079: Solanki_Himani");

        }
    }
}
