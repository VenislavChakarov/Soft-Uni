using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine()) / 1000;

            Console.WriteLine($"{meter:f2}");

        }
    }
}
