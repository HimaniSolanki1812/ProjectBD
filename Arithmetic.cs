using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Arithmetic
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: {0}", A + B);
            Console.WriteLine("Subtraction: {0}", A - B);
            Console.WriteLine("Multiplication: {0}", A * B);
            Console.WriteLine("Division: {0}", (double)A / B);
            Console.WriteLine("Modulus: {0}", A % B);

            double d = 12.5, e = 3.2;
            Console.WriteLine("Double Addition: {0}", d + e);
            Console.WriteLine("23SOECE11079 : Solanki_Himani");

        }
    }
}
