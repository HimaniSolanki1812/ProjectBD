using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program9
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            string toggle = "";
            foreach (char c in name)
            {
                if (char.IsUpper(c))
                    toggle += char.ToLower(c);
                else
                    toggle += char.ToUpper(c);
            }

            Console.WriteLine(toggle);
            Console.WriteLine("23SOECE11079  -- Solanki Himani");
        }
    }
}
