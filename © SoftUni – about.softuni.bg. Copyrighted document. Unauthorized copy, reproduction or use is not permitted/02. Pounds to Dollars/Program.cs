using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double british = double.Parse(Console.ReadLine()) * 1.31;

            Console.WriteLine($"{british:f3}");
        }
    }
}
