using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program28
    {
        static void Main()
        {
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            foreach (int note in notes)
            {
                int count = amount / note;
                amount %= note;
                Console.WriteLine("Notes of Rs.{0} = {1}", note, count);
            }
            Console.WriteLine("23SOECE11079: Solanki_Himani");

        }
    }
}
