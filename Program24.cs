using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program24
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 };
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (var kv in freq)
            {
                if (kv.Value == 1)
                    Console.Write(kv.Key + " ");
            }
            Console.WriteLine("23SOECE11079: Solanki_Himani");
        }
    }
}
