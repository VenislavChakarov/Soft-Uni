using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            string input = "";
            string name = "";
            string winnerName = "";

            for (int i = 1; i <= n; i++)
            {
                name = Console.ReadLine();
                int total = 0;
                while ((input = Console.ReadLine()) != "Stop")
                {
                    int points = int.Parse(input);

                    total += points;
                }
                Console.WriteLine($"{name} has {total} points.");

                if (totalPoints < total)
                {
                    totalPoints = total;
                    Console.WriteLine($"{name} is the new number 1!");
                    winnerName = name;
                }
            }
            Console.WriteLine($"{winnerName} won competition with {totalPoints} points!");
        }
    }
}
