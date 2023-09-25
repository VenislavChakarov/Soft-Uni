using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double cakePrice = rent * 0.20;
            double drinksPrice = cakePrice - (cakePrice * 0.45);
            double animator = rent / 3;

            double totalPrice = rent + cakePrice + animator + drinksPrice;
            Console.WriteLine(totalPrice);
        }
    }
}
