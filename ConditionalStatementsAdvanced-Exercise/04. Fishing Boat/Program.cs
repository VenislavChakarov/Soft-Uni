using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seoseon = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter
            double people = double.Parse(Console.ReadLine());

            double price = 0;
            switch (seoseon)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (people <= 6)
            {
                price *= 0.9;

            }
            else if (people > 7 && people <= 11)
            {
                price *= 0.85;
            }
            else if (people > 12)
            {
                price *= 0.75;
                
            }

            if ((people % 2 == 0) && seoseon != "Autumn")
            {
                price *= 0.95;
            }

            if (budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else 
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
