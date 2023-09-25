using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            double serialTime = double.Parse(Console.ReadLine());
            double free = double.Parse(Console.ReadLine());

            double lunchTime = free / 8;
            double relaxTime = free  / 4;
            double freeTime = free - lunchTime - relaxTime;
            double timeLeft = Math.Ceiling(serialTime - freeTime);

            if (serialTime<=freeTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {timeLeft} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {timeLeft} more minutes.");
            }
        }
    }
}
