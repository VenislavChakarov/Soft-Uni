﻿
using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourtNumber = int.Parse(Console.ReadLine());

            int firstOpretion = firstNumber + secondNumber;
            int secondOpretion = firstOpretion / thirdNumber;
            int thirdOpertion = secondOpretion * fourtNumber;

            Console.WriteLine(thirdOpertion);
        }
    }
}
