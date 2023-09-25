using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //„+“, „-“, „*“, „/“, „%
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string use = Console.ReadLine();

            switch (use)
            {
                case "+":
                    double sum = N1 + N2;
                    if (sum % 2 == 0) Console.WriteLine($"{N1} + {N2} = {sum} - even");
                    else Console.WriteLine($"{N1} + {N2} = {sum} - odd");
                    break;
                case "-":
                    double sum1 = N1 - N2;
                    if (sum1 % 2 == 0) Console.WriteLine($"{N1} - {N2} = {sum1} - even");
                    else Console.WriteLine($"{N1} - {N2} = {sum1} - odd");
                    break;
                case "*":
                    double sum2 = N2 * N1;
                    if (sum2 % 2 == 0) Console.WriteLine($"{N1} * {N2} = {sum2} - even");
                    else Console.WriteLine($"{N1} * {N2} = {sum2} - odd");
                    break;
                case "/":
                    double diff = N1 / N2;
                    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                    else Console.WriteLine($"{N1} / {N2} = {diff:f2}");
                    break;
                case "%":
                    double result = N1 % N2;
                    if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                    else Console.WriteLine($"{N1} % {N2} = {result}");
                    break;
            }
        }
    }
}
