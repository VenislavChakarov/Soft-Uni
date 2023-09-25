using System;

namespace ConditionalStatements_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime =int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int toalTime = firstTime + secondTime + thirdTime;

            int min = toalTime / 60;
            int sec = toalTime % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            
            
            }

        }
    }
}
