﻿
using System;

namespace _1._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age >= 66)
            {
                Console.WriteLine("elder");
            }
            else if (age >= 20)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 14)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 3)
            {
                Console.WriteLine("child");
            }
            else
            {
                Console.WriteLine("baby");
            }
        }
    }
}
