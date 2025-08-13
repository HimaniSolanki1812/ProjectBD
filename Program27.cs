using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program27
    {
        static void Main()
        {
            int[] arr = { 5, 10, 15, 20 };
            Console.Write("Enter element to search: ");
            int key = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            foreach (int val in arr)
            {
                if (val == key)
                {
                    found = true;
                    break;
                }
            }

            Console.WriteLine(found ? 1 : 0);
            Console.WriteLine("23SOECE11079: Solanki_Himani");

        }
    }
}
