using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Mobile No: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine(masked);
                Console.WriteLine("23SOECE11079:-Solanki Himani");
            }
        }
    }
}
