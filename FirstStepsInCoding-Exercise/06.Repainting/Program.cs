using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int paintThinnerL = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());


            double nylonPrice = (nylon + 2) * 1.50;
            double paintLPrice = (paintLiters + paintLiters* 0.1) * 14.50;
            double paintThinnerLPrice = paintThinnerL * 5.00;


            double matirialsPrice = nylonPrice + paintLPrice + paintThinnerLPrice + 0.40;
            double painterPrice = (matirialsPrice * 0.30) * hours;
            double fullPrice = matirialsPrice + painterPrice;

            Console.WriteLine(fullPrice);
            
        }
    }
}
