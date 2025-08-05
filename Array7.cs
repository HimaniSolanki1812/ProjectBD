using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Array7
    {
        static void Main()
        {
            int[] numbers = new int[5];
            int[] evenNumbers = new int[5];
            int[] oddNumbers = new int[5];
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[evenCount] = numbers[i];
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount] = numbers[i];
                    oddCount++;
                }
            }

            Console.WriteLine("\nEven integers are:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }

            Console.WriteLine("\nOdd integers are:");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddNumbers[i] + " ");

            }
            Console.WriteLine("\n23SOECE11079: Solanki_Himani");
        }
    }
}
