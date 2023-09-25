using System;
using System.Diagnostics;

namespace _03._Histogram
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

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1count++;
                }
                else if (num < 400)
                {
                    p2count++;
                }
                else if (num < 600)
                {
                    p3count++;
                }
                else if (num < 800)
                {
                    p4count++;
                }
                else if (num >= 800)
                {
                    p5count++;
                }
                
            }
            double P1 = p1count / n * 100;
            double P2 = p2count / n * 100;
            double P3 = p3count / n * 100;
            double P4 = p4count / n * 100;
            double P5 = p5count / n * 100;

            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{P2:f2}%");
            Console.WriteLine($"{P3:f2}%");
            Console.WriteLine($"{P4:f2}%");
            Console.WriteLine($"{P5:f2}%");
        }
    }
}
