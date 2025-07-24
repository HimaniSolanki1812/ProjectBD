using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program23
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
            //index wise
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("for each loop");
        //element wise
        foreach(int i in arr)
            {
                Console.WriteLine("using foreach loop");
            }
        }
    }
}
