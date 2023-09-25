using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double money = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);
                switch (coins)
                {
                    case 0.1:
                        money += 0.1;
                        break;
                    case 0.2:
                        money += 0.2;
                        break;
                    case 0.5:
                        money += 0.5;
                        break;
                    case 1:
                        money += 1;
                        break;
                    case 2:
                        money += 2;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Nuts")
                {
                    if (money < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                }
                else if (input == "Water")
                {
                    if (money < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    
                }
                else if (input == "Crisps")
                {
                    if (money < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }                
                }
                else if (input == "Soda")
                {
                    if (money < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                }
                else if (input == "Coke")
                { 
                    if (money < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
