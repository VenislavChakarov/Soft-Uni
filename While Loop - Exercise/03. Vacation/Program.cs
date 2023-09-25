using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double moneyNow = double.Parse(Console.ReadLine());

            int speendCount = 0;
            int days = 0;

            while (tripPrice > moneyNow)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                if (action == "spend")
                {
                    speendCount++;
                    moneyNow -= money;
                    if (moneyNow < 0)
                    {
                        moneyNow = 0;
                    }
                    if (speendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }

                }
                else if (action == "save")
                {
                    speendCount = 0;
                    moneyNow += money;
                }

            }

            if (tripPrice <= moneyNow)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
