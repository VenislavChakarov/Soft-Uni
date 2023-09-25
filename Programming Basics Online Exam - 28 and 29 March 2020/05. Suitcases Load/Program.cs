using System;
using System.Security;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double storage = double.Parse(Console.ReadLine());
            string input;

            int suitcaseCounter = 0;
            double totalSum = 0;
            int counter = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                double suitcase = double.Parse(input);
                counter++; 

                if (counter == 3)
                {
                    suitcase = suitcase + Math.Round(suitcase * 0.10 , 2);
                    totalSum += suitcase;
                    counter = 0;
                }
                else
                {
                    totalSum += suitcase;
                }

                if (storage < totalSum)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
                    break;
                }
                suitcaseCounter++;

            }
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
            }

            
        }
    }
}
