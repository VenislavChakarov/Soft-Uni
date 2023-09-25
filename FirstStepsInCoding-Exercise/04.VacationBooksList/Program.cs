using System;
using System.Runtime.InteropServices;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hours = bookPages / time;
            int  hoursForDay = hours / days;

            Console.WriteLine(hoursForDay);
        }
    }
}
