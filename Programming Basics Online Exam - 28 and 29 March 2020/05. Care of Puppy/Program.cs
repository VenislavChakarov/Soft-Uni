using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bougthFood = double.Parse(Console.ReadLine()) * 1000;
            string input = "";

            double eatenFood = 0;

            while ((input = Console.ReadLine()) != "Adopted")
            {
                double food = double.Parse(input);

                eatenFood += food;
            }
            double sum = Math.Abs(bougthFood - eatenFood);

            if (eatenFood <= bougthFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {sum} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sum} grams more.");
            }


        }
    }
}
