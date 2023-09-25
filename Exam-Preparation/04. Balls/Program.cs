using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int difrentBalls = 0;
            int blackBalls = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    totalPoints += 5;
                    redBalls++;
                }
                else if (color == "orange")
                {
                    totalPoints += 10;
                    orangeBalls++;
                }
                else if (color == "yellow")
                {
                    totalPoints += 15;
                    yellowBalls++;
                }
                else if (color == "white")
                {
                    totalPoints += 20;
                    whiteBalls++;
                }
                else if (color == "black")
                {
                    totalPoints = totalPoints / 2;
                    blackBalls++;
                }
                else
                {
                    difrentBalls++;
                }
            }
            
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {difrentBalls}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");
        }
    }
}
