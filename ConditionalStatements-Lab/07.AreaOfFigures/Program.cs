using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double squareArea = a * a;

                Console.WriteLine("{0:F3}", squareArea);
            }
            else if (figure == "rectangle")
            {
                double h = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double rectangleArea = b * h;

                Console.WriteLine("{0:F3}", rectangleArea);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double circleArea = Math.PI * Math.Pow(r, 2);

                Console.WriteLine($"{circleArea:F3}");

            }
            else if (figure == "triangle")
            {
                double B = double.Parse(Console.ReadLine());
                double H = double.Parse(Console.ReadLine());

                double triangleArea = (B * H) / 2;

                Console.WriteLine("{0:F3}", triangleArea);
            }




        }
    }
}
