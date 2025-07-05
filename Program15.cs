using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("23SOECE11079:-Solanki Himani");
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, temp, rem;
            temp = num;

            while (temp != 0)
            {
                rem = temp % 10;
                sum += rem * rem * rem;
                temp /= 10;
            }

            if (sum == num)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");
        }
    }
}
