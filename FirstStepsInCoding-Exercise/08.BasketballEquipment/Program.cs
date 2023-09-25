using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearForTraining = int.Parse(Console.ReadLine());

            double shoes = yearForTraining - yearForTraining * 0.40;
            double clothes = shoes - shoes * 0.20;
            double balls = clothes / 4;
            double acsesories = balls / 5;

            double priceForAll = yearForTraining + shoes + clothes + balls + acsesories;

            Console.WriteLine(priceForAll);




        }
    }
}
