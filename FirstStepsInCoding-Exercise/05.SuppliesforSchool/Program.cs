using System;
using System.Runtime.CompilerServices;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) / 100;

            double penPackets = pens * 5.80;
            double markersPackets = markers * 7.20;
            double amountLiters = liters * 1.20;

            double totalPice = penPackets + markersPackets + amountLiters-((penPackets + markersPackets + amountLiters) * discount);

            Console.WriteLine(totalPice);
        }
    }
}
