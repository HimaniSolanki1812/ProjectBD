using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Number_Manipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y;   /* put y into x */
            y = temp; /* put temp into y */
        }
    }
    class TestRef
    {
        static void Main(string[] args)
        {
            Number_Manipulator n = new Number_Manipulator();
            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
            Console.WriteLine("23SOECE11079 : Solanki_Himani");

        }
    }


}
