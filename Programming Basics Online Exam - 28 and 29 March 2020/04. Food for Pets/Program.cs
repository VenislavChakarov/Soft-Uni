using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double dogFood = 0;
            double catFood = 0;
            double cookies = 0;

            for (int i = 1; i <= days; i++)
            {
                double foodForDog = double.Parse(Console.ReadLine());
                double foodForCat = double.Parse(Console.ReadLine());
                dogFood += foodForDog;
                catFood += foodForCat;

                if (i % 3 == 0 )
                {
                    cookies += (foodForCat + foodForDog) * 0.10;
                }
            }
             double tootalFood = catFood + dogFood;

            double eatenFood = (tootalFood / food) * 100;
            double dogPercent = (dogFood / tootalFood) * 100;
            double catPercent = (catFood / tootalFood) * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{eatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogPercent:f2}% eaten from the dog.");
            Console.WriteLine($"{catPercent:f2}% eaten from the cat.");
        }
    }
}
