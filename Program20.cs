﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BD
{
    internal class Program20
    {
        public static void Main(string[] args)
        {
            int n = 4, k = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int l = 1; l <= i; l++)
                    Console.Write(k++ + " ");
                Console.WriteLine();
            }
            Console.WriteLine("23SOECE11079  -- Solanki Himani");
        }
    }
}
