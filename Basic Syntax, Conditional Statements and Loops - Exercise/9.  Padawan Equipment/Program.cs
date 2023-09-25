using System;

namespace _9.__Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yodasMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freeBelts = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double moreSabers = Math.Ceiling(students * 1.10 - students);

            double sabersCost = (moreSabers + students) * lightSaberPrice;
            double robesCost = robesPrice * students;
            double beltsCost = beltsPrice * students - (freeBelts * beltsPrice);

            double totalPrice = sabersCost + robesCost + beltsCost;

            if (yodasMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(totalPrice - yodasMoney):f2}lv more.");
            }


        }
    }
}
