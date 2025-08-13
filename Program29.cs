using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program29
    {
        static void Main()
        {
            Console.Write("Input Maths marks: ");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Physics marks: ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Chemistry marks: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            int totalAll = maths + phy + chem;
            int totalMP = maths + phy;

            if ((maths >= 65 && phy >= 55 && chem >= 50 && totalAll >= 180) ||
                (totalMP >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.WriteLine("23SOECE11079: Solanki_Himani");

        }
    }
}
