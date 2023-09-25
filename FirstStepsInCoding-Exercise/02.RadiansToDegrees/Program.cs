using System;

namespace _02.RadiansToDegrees
{
    internal class Program
    {

        static void Main(string[]  args)
        {
            double Radians = double.Parse(Console.ReadLine());
            double Degrees = Radians * 180 / Math.PI;

            Console.WriteLine(Degrees);
        }
    }
}
