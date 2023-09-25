using System;
using System.Net;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            double NPrice = N * 250;
            double MPrice = NPrice * 0.35;
            double MAmount = M * MPrice;
            double PPRice = NPrice * 0.10;
            double PAmount = P * PPRice;

            double totalPrice = NPrice + MAmount + PAmount;

            if (N > M)
            {
                totalPrice -= totalPrice * 0.15;
            }
            double diff = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {diff:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
            }
        }
    }
}
