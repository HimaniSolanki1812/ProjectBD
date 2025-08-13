using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Sum_of_Array
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] arr = new int[5];
                int sum = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter Element {0}: ", i);
                    string str = Console.ReadLine();
                    arr[i] = Convert.ToInt32(str);
                }

                for (int i = 0; i < 5; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine("Sum of Elements : {0}", sum);
                Console.WriteLine("23SOECE11079 : Solanki_Himani");
                Console.ReadLine();
            }
        }
    }
}
