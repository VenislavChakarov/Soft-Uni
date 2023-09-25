using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double timeForEpisode = int.Parse(Console.ReadLine());

            double add = 0;

            add = timeForEpisode * 0.20;

            double timeWithAdd = timeForEpisode + add;
            double specialEpisode = seasons * 10;

            double total = timeWithAdd * episodes * seasons + specialEpisode;

            Console.WriteLine($"Total time needed to watch the {serial} series is {total} minutes.");
        }
    }
}
