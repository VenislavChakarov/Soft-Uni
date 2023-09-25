using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            switch (type)
            {
                case "Roses":
                    price = 5; break;
                case "Dahlias":
                    price = 3.80; break;
                case "Tulips":
                    price = 2.80; break;
                case "Narcissus":
                    price = 3; break;
                case "Gladiolus":
                    price = 2.50; break;

            }

            double totalPrice = amount * price;
            if (amount > 80 && type == "Roses")
            {
                totalPrice *= 0.9;
            }
            else if (amount > 90 && type == "Dahlias")
            {
                totalPrice *= 0.85;
            }
            else if (amount > 80 && type == "Tulips")
            {
                totalPrice *= 0.85;
            }
            else if (amount < 120 && type == "Narcissus")
            {
                totalPrice *= 1.15;
            }
            else if (amount < 80 && type == "Gladiolus")
            {
                totalPrice *= 1.20;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {amount} {type} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

        }
    }
}
