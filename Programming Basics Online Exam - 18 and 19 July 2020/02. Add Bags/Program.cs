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



            if (suitcaseWeight < 10)
            {
                suitcasePrice *= 0.20;
            }
            else if (suitcaseWeight >= 10 && suitcaseWeight <= 20)
            {
                suitcasePrice = suitcasePrice * 0.5;
            }
            else if (suitcaseWeight > 20)
            {
                suitcasePrice = suitcasePrice;
            }

            if (days <= 7)
            {
                suitcasePrice *= 1.40;
            }
            else if (days >= 7 && days <= 30)
            {
                suitcasePrice *= 1.15 ;
            }
            else if (days > 30 )
            {
                suitcasePrice *= 1.10;
            }

            double total = suitcasePrice * totalSuitcases;

            Console.WriteLine($" The total price of bags is: {total:f2} lv. ");

        }
    }
}
