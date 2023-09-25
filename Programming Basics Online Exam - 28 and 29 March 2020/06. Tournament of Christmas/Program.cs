using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string input;
            int winCounter = 0;
            int loseCounter = 0;
            double winedMoney = 0;

            for (int i = 1; i <= day; i++)
            {
                int win = 0;
                int lose = 0;
                double money = 0;

                while ((input = Console.ReadLine()) != "Finish")
                {
                    string winOrLose = Console.ReadLine();

                    if (winOrLose == "win")
                    {
                        win++;
                        winCounter++;
                        money += 20;
                    }
                    else if (winOrLose == "lose")
                    {
                        lose++;
                        loseCounter++;
                    }
                }

                if (win > lose)
                {
                    money = money + (money * 0.10);
                }
                winedMoney += money;
            }
            if (winCounter > loseCounter)
            {
                double totalMoney = winedMoney + (winedMoney * 0.20);
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {winedMoney:f2}");
            }
        }
    }
}
