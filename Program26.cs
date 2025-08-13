using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program26
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("23SOECE11079: Solanki_Himani");

        }
    }
}
