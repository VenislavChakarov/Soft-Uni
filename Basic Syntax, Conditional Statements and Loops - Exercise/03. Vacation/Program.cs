
using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double total = 0;
            double businDisc = 0;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    total = people * 8.45;
                }
                else if (type == "Business")
                {
                    total = people * 10.90;
                    businDisc = 10 * 10.90;
                }
                else
                {
                    total = people * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    total = people * 9.80;
                }
                else if (type == "Business")
                {
                    total = people * 15.60;
                    businDisc = 10 * 15.60;
                }
                else
                {
                    total = people * 20;
                }
            }
            else
            {
                if (type == "Students")
                {
                    total = people * 10.46;
                }
                else if (type == "Business")
                {
                    total = people * 16;
                    businDisc = 10 * 16;
                }
                else
                {
                    total = people * 22.50;
                }
            }

            if (people >= 30 && type == "Students")
            {
                total *= 0.85;
            }
            else if (people >= 100 && type == "Business")
            {
                total -= businDisc;
            }
            else if ((people >= 10 && people <= 20) && type == "Regular")
            {
                total *= 0.95;
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
