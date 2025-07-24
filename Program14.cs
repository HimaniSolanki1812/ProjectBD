using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program14
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("23SOECE11079  -- Solanki Himani");
            //Console.Write("Enter Number: ");
            //string number = Console.ReadLine();

            //foreach (char digit in number)
            //{
            //    switch (digit)
            //    {
            //        case '0': Console.Write("Zero "); break;
            //        case '1': Console.Write("One "); break;
            //        case '2': Console.Write("Two "); break;
            //        case '3': Console.Write("Three "); break;
            //        case '4': Console.Write("Four "); break;
            //        case '5': Console.Write("Five "); break;
            //        case '6': Console.Write("Six "); break;
            //        case '7': Console.Write("Seven "); break;
            //        case '8': Console.Write("Eight "); break;
            //        case '9': Console.Write("Nine "); break;
            //    }
            //}
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] dig = { "zero ", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine " };
            string result = null;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                result = dig[digit] + result;


            }
            Console.WriteLine(result);

        }
    }
}
