using System.Security;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;

            for (int i = 1; i <= n; i++)
            {
                int amount = int.Parse(Console.ReadLine());
                sum1 += amount;
                if (sum1 > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum1 -= amount;
                }
                else if (sum1 <= 255)
                {
                    sum+= amount;
                }

            }
            Console.WriteLine(sum);
        }
    }
}