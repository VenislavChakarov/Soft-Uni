using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivary = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (type == "90X130")
            {
                price = 110;
                totalPrice = price * count;
                if (count > 60)
                {
                    totalPrice *= 0.92;
                }
                else if (count > 30)
                {
                    totalPrice *= 0.95;
                }
            }
            else if (type == "100X150")
            {
                price = 140;
                totalPrice = price * count;
                if (count > 80)
                {
                    totalPrice *= 0.9;
                }
                else if (count > 40)
                {
                    totalPrice *= 0.94;
                }
            }
            else if (type == "130X180")
            {
                price = 190;
                totalPrice = price * count;

                if (count > 50)
                {
                    totalPrice *= 0.88;
                }
                else if (count > 20)
                {
                    totalPrice *= 0.93;
                }
            }
            else if (type == "200X300")
            {
                price = 250;
                totalPrice = price * count;
                if (count > 50)
                {
                    totalPrice *= 0.86;
                }
                else if (count > 25)
                {
                    totalPrice *= 0.91;
                }
            }
         
            if (delivary == "With delivery")
            {
                totalPrice += 60;
            }

            if (count > 99)
            {
                totalPrice *= 0.96;
            }

            if (count < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2} BGN");
            } 
        }
    }
}
