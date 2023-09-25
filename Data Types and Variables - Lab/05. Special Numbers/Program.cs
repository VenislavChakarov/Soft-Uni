
using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = 0;
                int digit = i;
                while (digit > 0)
                {
                    num += digit % 10;
                    digit = digit / 10;
                }
                

                if (num == 5 || num == 7 || num == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
