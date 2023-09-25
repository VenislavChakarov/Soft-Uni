using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1lv, 2lv,50st,20st,10st,5st,2st,1st
            double resto = double.Parse(Console.ReadLine()) * 100;
            int coin = 0;

            while (resto > 0) 
            {
                if (resto >= 200)
                {
                    resto -= 200;
                    coin++;
                }
                else if (resto >= 100)
                {
                    resto -= 100;
                    coin++;
                }
                else if (resto >= 50)
                {
                    resto -= 50;
                    coin++;
                }
                else if (resto >= 20)
                {
                    resto -= 20;
                    coin++;
                }
                else if (resto >= 10)
                {
                    resto -= 10;
                    coin++;
                }
                else if (resto >= 5)
                {
                    resto -= 5;
                    coin++;
                }
                else if (resto >= 2)
                {
                    resto -= 2;
                    coin++;
                }
                else if (resto >= 1) 
                {
                    resto -= 1;
                    coin++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(coin);


        }
    }
}
