using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsCounter = 0;
            string input;

            while (stepsCounter < 10000)
            {
                input = Console.ReadLine();
                

                if (input == "Going home")
                {
                    stepsCounter += int.Parse(Console.ReadLine());
                    break;
                }
                stepsCounter += int.Parse(input);

            }
            if (stepsCounter >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsCounter - 10000} steps over the goal!");
            }
            else 
            {
                Console.WriteLine($"{Math.Abs(stepsCounter - 10000)} more steps to reach goal.");
            }

        }
    }
}
