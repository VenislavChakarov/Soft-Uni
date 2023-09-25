using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); 
            string season = Console.ReadLine();

            double discount = 0;
            string type = "";
            string destination = "";
            
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    discount = budget - 0.7 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    discount = budget - 0.3 * budget;
                    type = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    discount = budget - 0.6 * budget;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    discount = budget - 0.2 * budget;
                    type = "Hotel";
                }

            }
            else if (budget > 1000) 
            {
                destination = "Europe";
                discount = budget - 0.1 * budget;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {discount:f2}"); 

        }
    }
}
