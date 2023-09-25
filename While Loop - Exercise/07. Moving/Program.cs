using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int volume = length * weight * hight;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                volume -= int.Parse(input);

                if (volume < 0) 
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done") 
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }

        }
    }
}
