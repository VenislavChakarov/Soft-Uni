﻿using System;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;

            while (true)
            {
                input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    break; // Terminate the program
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
        }
    }
}
