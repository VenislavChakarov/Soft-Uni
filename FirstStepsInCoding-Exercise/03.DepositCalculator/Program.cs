using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double depositValue = double.Parse(Console.ReadLine());
            int mounths = int.Parse(Console.ReadLine());
            double depositGainValue = double.Parse(Console.ReadLine()) / 100;

            double totalGain = depositValue + mounths * ((depositValue * depositGainValue) / 12);

            Console.WriteLine(totalGain);
                

        }
    }
} 
