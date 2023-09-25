using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string type = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            double price = 0;
            if (fruit == "Watermelon")
            {
                if (type == "big")
                {
                    price = 28.70 * 5;
                }
                else if (type == "small")
                {
                    price = 56 * 2;
                }
            }
            else if (fruit == "Mango")
            {
                if (type == "big")
                {
                    price = 19.60 * 5;
                }
                else if (type == "small")
                {
                    price = 36.66 * 2;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (type == "big")
                {
                    price = 24.80 * 5;
                }
                else if (type == "small")
                {
                    price = 42.10 * 2;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (type == "big")
                {
                    price = 15.20 * 5;
                }
                else if (type == "small")
                {
                    price = 20 * 2;
                }
            }

            double totalPrice = price * amount;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.50;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
