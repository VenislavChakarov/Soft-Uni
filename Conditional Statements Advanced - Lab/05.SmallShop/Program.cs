﻿using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine(); 
            double amount = double.Parse(Console.ReadLine());

            double price = 0;
            if (city == "Sofia")
            {
                if (product == "coffee") price = amount * 0.5;
                else if (product == "water") price = amount * 0.8;
                else if (product == "beer") price = amount * 1.2;
                else if (product == "sweets") price = amount * 1.45;
                else if (product == "peanuts") price = amount * 1.6;

                Console.WriteLine(price);
            }
            else if (city == "Plovdiv")
            {

                if (product == "coffee") price = amount * 0.4;
                else if (product == "water") price = amount * 0.7;
                else if (product == "beer") price = amount * 1.15;
                else if (product == "sweets") price = amount * 1.3;
                else if (product == "peanuts") price = amount * 1.5;

                Console.WriteLine(price);
            }
            else if (city == "Varna")
            {
                if (product == "coffee") price = amount * 0.45;
                else if (product == "water") price = amount * 0.7;
                else if (product == "beer") price = amount * 1.1;
                else if (product == "sweets") price = amount * 1.35;
                else if (product == "peanuts") price = amount * 1.55;

                Console.WriteLine(price);
            }
        }
    }
}