﻿using System;

namespace Uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x>=10 && x<=20)
                {
                    cont_in++;
                }
                else
                {
                    cont_out++;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

            Console.ReadLine();
        }
    }
}
