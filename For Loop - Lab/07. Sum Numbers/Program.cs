﻿using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                sum += n1;
            }
            Console.WriteLine(sum);
        }
    }
}
