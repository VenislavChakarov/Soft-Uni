using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double price = 0;

            if (color == "Red")
            {
                if (size == "Large")
                {
                    price = 16;
                }
                else if (size == "Medium")
                {
                    price = 13;
                }
                else if (size == "Small")
                {
                    price = 9;
                }
            }
            else if(color == "Green")
            {
                if (size == "Large")
                {
                    price = 12;
                }
                else if (size == "Medium")
                {
                    price = 9;
                }
                else if (size == "Small")
                {
                    price = 8;
                }
            }
            else if (color == "Yellow")
            {
                if (size == "Large")
                {
                    price = 9;
                }
                else if (size == "Medium")
                {
                    price = 7;
                }
                else if (size == "Small")
                {
                    price = 5;
                }
            }

            double totalPrice = price * amount;
            double diff = Math.Round(totalPrice * 0.35 , 2);
            double diff2 =Math.Abs(diff - totalPrice);

            Console.WriteLine($"{diff2:f2} leva.");
        }
    }
}
