using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int legthCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            int vFishTank = legthCm * widthCm * heightCm;
            double vLiters = vFishTank * 0.001;

            double litersNeed = vLiters * (1 - percent);

            Console.WriteLine(litersNeed);

        }
    }
}
