using System;
using System.Collections.Concurrent;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double min = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double meaters = double.Parse(Console.ReadLine());
            double secMeaters = double.Parse(Console.ReadLine());

            double recodTime = min * 60 + sec;
            double diff = meaters / 120;
            double totalRemovedTime = diff * 2.5;
            double marinTime = (meaters / 100) * secMeaters - totalRemovedTime;

            if (recodTime >= marinTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(marinTime - recodTime):f3} second slower.");
            }
        }
    }
}
