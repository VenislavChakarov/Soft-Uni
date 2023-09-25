using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double filmCost = double.Parse(Console.ReadLine());
            double statist = double.Parse(Console.ReadLine());
            double cloths = double.Parse(Console.ReadLine());

            double decoretion = filmCost * 0.1;
            double clothsPrice = statist * cloths;

            if (statist >= 150) 
            {
                clothsPrice -= clothsPrice * 0.10;
            }
            double totalPrice = decoretion + clothsPrice;
            double diff = Math.Abs(totalPrice - filmCost);
            if (totalPrice > filmCost)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:F2} leva more.");
            }
            else if (filmCost >= totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
            }
        }
    }
}
