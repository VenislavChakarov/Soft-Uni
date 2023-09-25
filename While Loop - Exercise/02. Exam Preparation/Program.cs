using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fails = int.Parse(Console.ReadLine());

            int exCount = 0;
            int failsCount = 0;
            double rateingSum = 0;
            string lastEx = "";
            bool isFaild = true;

            while (failsCount < fails)
            {
                string input = Console.ReadLine();
                if ("Enough" == input )
                {
                    isFaild = false;
                    break;
                }
                int rating = int.Parse(Console.ReadLine());
                if (rating <= 4)
                {
                    failsCount++;
                }
                rateingSum += rating;
                exCount++;
                lastEx = input;

            }
            if (isFaild)
            {
                Console.WriteLine($"You need a break, {failsCount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {rateingSum / exCount:F2}");
                Console.WriteLine($"Number of problems: {exCount}");
                Console.WriteLine($"Last problem: {lastEx}");
            }
            

        }
    }
}
