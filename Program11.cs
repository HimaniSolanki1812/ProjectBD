using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program11
    {
        public static void Main(string[] args)
            {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Gender (M/F): ");
        char gender = Convert.ToChar(Console.ReadLine().ToUpper());

        if (gender == 'M')
            Console.WriteLine("Mr. " + name);
        else if (gender == 'F')
            Console.WriteLine("Ms. " + name);
        else
            Console.WriteLine("Invalid Gender");
            Console.WriteLine("23SOECE11079:-Solanki Himani");
    }
    }
}
