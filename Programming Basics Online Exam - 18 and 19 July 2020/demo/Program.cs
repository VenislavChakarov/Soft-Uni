using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suitcasePrice = double.Parse(Console.ReadLine());
            double suitcaseWeight = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double totalSuitcases = double.Parse(Console.ReadLine());

            if (suitcaseWeight <= 10)
            {
                double discount = suitcasePrice * 0.20;
                suitcasePrice -= discount;
            }
            else if (suitcaseWeight > 10 && suitcaseWeight <= 20)
            {
                suitcasePrice *= 1.5;
            }
            else
            {
                suitcasePrice *= 1.2;
            }

            if (days < 7)
            {
                suitcasePrice *= 1.4;
            }
            else if (days >= 7 && days <= 30)
            {
                suitcasePrice *= 1.15;
            }
            else
            {
                suitcasePrice *= 1.1;
            }

            double total = suitcasePrice * totalSuitcases;

            Console.WriteLine($"The total price of bags is: {total:f2} lv.");
        }
    }
}
