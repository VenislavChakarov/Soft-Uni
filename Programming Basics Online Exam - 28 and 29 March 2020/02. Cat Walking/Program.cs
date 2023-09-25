using System;
using System.Collections.Concurrent;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mins = int.Parse(Console.ReadLine());
            int walks = int.Parse(Console.ReadLine());
            int kaloris = int.Parse(Console.ReadLine());

            int totalWalkTime =  mins * walks;
            int burnedKaloris = totalWalkTime * 5;

            double kalorisNeededToBurn = kaloris * 0.50;

            if (burnedKaloris >= kalorisNeededToBurn)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedKaloris}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedKaloris}.");
            }
        }
    }
}
