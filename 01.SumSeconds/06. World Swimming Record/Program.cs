using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double metears = double.Parse(Console.ReadLine());
            double mPerSec = double.Parse(Console.ReadLine());

            double mNeeded = metears * mPerSec;
            double around = Math.Floor(metears / 15);
            double givenTime = around * 12.5;
            double totalTime = mNeeded + givenTime;

            if (sec > totalTime)  
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }    
            else 
            {
                Console.WriteLine($"No, he failed! He was {totalTime - sec:f2} seconds slower.");
            }
        }
    }
}
