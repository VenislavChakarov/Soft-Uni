using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegaMenu = int.Parse(Console.ReadLine());

            double chikenMenuPrice = chikenMenu * 10.35;
            double fihsMenuPrice = fishMenu * 12.40;
            double vegaMenuPrice = vegaMenu * 8.15;
            

            double menuesPrice = chikenMenuPrice + fihsMenuPrice + vegaMenuPrice;
            double desert = 0.20 * menuesPrice;

            double deliveryPrice = menuesPrice + desert + 2.50;

            Console.WriteLine(deliveryPrice);

        }
    }
}
