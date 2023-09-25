using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string voteName = Console.ReadLine();
                double votePoints = double.Parse(Console.ReadLine());

                points += voteName.Length * votePoints / 2;

                if (points >= 1250.5) 
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            double needed = Math.Abs(points - 1250.5);
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {needed:f1} more!");
            }
        }
    }
}
