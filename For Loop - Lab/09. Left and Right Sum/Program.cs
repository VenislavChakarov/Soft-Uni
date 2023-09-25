using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int RigthSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                RigthSum += num;
            }

            int LeftSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                LeftSum += num;
            }

            if (LeftSum == RigthSum) 
            {
                Console.WriteLine($"Yes, sum = {LeftSum}");
            }
            else
            {
                int diff = Math.Abs(LeftSum - RigthSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
