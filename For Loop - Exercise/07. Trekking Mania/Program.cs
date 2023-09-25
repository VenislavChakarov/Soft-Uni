using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1count = 0;
            double p2count = 0;
            double p3count = 0;
            double p4count = 0;
            double p5count = 0;

            int people = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                people += num;

                if (num <= 5)
                {
                    p1count += num;
                }
                else if (num <= 12)
                {
                    p2count += num;
                }
                else if (num <= 25)
                {
                    p3count += num;
                }
                else if (num <= 40)
                {
                    p4count += num;
                }
                else if (num >= 41)
                {
                    p5count += num;
                }

            }
            double P1 = p1count / people * 100;
            double P2 = p2count / people * 100;
            double P3 = p3count / people * 100;
            double P4 = p4count / people * 100;
            double P5 = p5count / people * 100;

            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{P2:f2}%");
            Console.WriteLine($"{P3:f2}%");
            Console.WriteLine($"{P4:f2}%");
            Console.WriteLine($"{P5:f2}%");
        }
    }
}
