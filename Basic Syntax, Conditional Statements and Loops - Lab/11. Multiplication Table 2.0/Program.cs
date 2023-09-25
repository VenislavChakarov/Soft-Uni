
using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
            if (a > 10)
            {
                Console.WriteLine($"{n} X {a} = {n * a}");
            }
        }
    }
}
