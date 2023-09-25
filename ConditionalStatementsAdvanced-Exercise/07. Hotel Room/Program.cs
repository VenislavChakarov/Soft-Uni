using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine(); //May, June, July, August, September или October
            double day = double.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
            }
            else if (mounth == "July" || mounth == "August") 
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            double studioTotal = studioPrice * day;
            double apartmentTotal = apartmentPrice * day;

            if (day > 14 && (mounth == "May" || mounth == "October"))
            {
                studioTotal *= 0.7;
            }
            else if (day > 7 && (mounth == "May" || mounth == "October"))
            {
                studioTotal *= 0.95;
            }
            else if (day > 14 && (mounth == "June" || mounth == "September")) 
            {
                studioTotal *= 0.8;
            }

            if (day > 14) 
            {
                apartmentTotal *= 0.9;
            }
            Console.WriteLine($"Apartment: {apartmentTotal:F2} lv.");
            Console.WriteLine($"Studio: {studioTotal:F2} lv.");
        }
    }
}
