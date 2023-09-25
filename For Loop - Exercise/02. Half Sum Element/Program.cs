using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max) max = num;
                sum += num;
            }
            int sum1 = sum - max;
            if (sum1 == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum1);
            }
            else 
            {
                int diff = Math.Abs(sum1 - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
