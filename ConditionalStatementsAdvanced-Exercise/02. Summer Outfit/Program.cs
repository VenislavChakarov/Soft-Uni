using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heat = double .Parse(Console.ReadLine()); //"Morning", "Afternoon", "Evening"
            string time = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (heat >= 10 && heat <= 18)
            {
                if (time == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (time == "Afternoon" || time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (heat >= 18 && heat <= 24)
            {
                if (time == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (time == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (heat >= 25) 
            {
                if (time == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (time == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {heat} degrees, get your {outfit} and {shoes}.");

        }
    }
}
