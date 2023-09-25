using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string airCompany = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double onlinePrice = double.Parse(Console.ReadLine());
            double taks = double.Parse(Console.ReadLine());

            double kidTicketPrice = onlinePrice - (onlinePrice * 0.70);
            double adultTaks =  onlinePrice + taks;
            double kidsTaks = kidTicketPrice + taks;

            double totalPrice = (kidsTickets * kidsTaks) + (adultTickets * adultTaks);
            double sum = totalPrice * 0.20;

            Console.WriteLine($"The profit of your agency from {airCompany} tickets is {sum:f2} lv.");

        }
    }
}
