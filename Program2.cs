using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter DOB (dd/mm/yyyy): ");
            string dob = Console.ReadLine();

            Console.Write("Enter Address Line 1: ");
            string address1 = Console.ReadLine();

            Console.Write("Enter Address Line 2: ");
            string address2 = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter Pincode: ");
            string pincode = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Country: ");
            string country = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n********* PROFILE *********");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Address: " + address1);
            Console.WriteLine("         " + address2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Pincode: " + pincode);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("23SOECE11079 -- Solanki Himani");

        }
    }
}
