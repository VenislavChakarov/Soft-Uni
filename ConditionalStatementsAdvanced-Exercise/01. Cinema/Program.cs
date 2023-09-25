using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double rowls = double.Parse(Console.ReadLine());
            double colums = double.Parse(Console.ReadLine());

            double seats = rowls * colums;
            double price = 0;
            switch (type) 
            {
                case "Premiere":
                    price = seats * 12.00;
                    break;
                case "Normal":
                    price = seats * 7.50;
                    break;
                case "Discount":
                    price = seats * 5.00;
                        break;
            }

            Console.WriteLine($"{price:f2} leva");
        }
    }
}
