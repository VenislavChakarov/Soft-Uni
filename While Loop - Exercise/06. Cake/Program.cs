using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int higth = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            int pices = higth * weight;
            string input = Console.ReadLine();

            while (input != "STOP") 
            {
                pices -= int.Parse(input);

                if (pices < 0) 
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pices)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{pices} pieces are left.");
            }
        }
    }
}
