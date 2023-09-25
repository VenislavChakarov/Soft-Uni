using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());    
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double puzzelsPrice = puzzels * 2.60;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.10;
            double minionsPrice = minions * 8.20;
            double truckPrice = truck * 2;

            double price = puzzelsPrice + dollsPrice + bearsPrice + minionsPrice + truckPrice;

            double sum = puzzels + dolls + bears + minions + truck;
            if ( sum >= 50)
            {
                double discount = 0.25 * price;

                double totalPrice = price - discount;

                double rent = 0.10 * totalPrice;

                double profit = totalPrice - rent;

                double leftMoney = profit - trip;

                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else 
            {
                double rent = 0.10 * price;

                double profit = price - rent;

                double moneyLeft = trip - profit;

                Console.WriteLine($"Not enough money! {moneyLeft:F2} lv needed.");
            }
            


        }
    }
}
