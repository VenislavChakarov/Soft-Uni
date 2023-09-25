using System;
using System.Security.Cryptography;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            double money = 0;
            int toys = 0;

            //i rojden den 
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 ==0)
                {
                    money += 5 * i  - 1; 
                }
                else
                {
                    toys += toysPrice;
                }
            }
            double total = money + toys;
            double sum = Math.Abs(total - present);
            if (total >= present)
            {
                Console.WriteLine($"Yes! {sum:F2}");
            }
            else
            {
                Console.WriteLine($"No! {sum:f2}");
            }
        }
    }
}
