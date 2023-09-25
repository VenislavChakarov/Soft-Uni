using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string conection = Console.ReadLine();

            Console.WriteLine($"{firstName}{conection}{lastName}");
        }
    }
}
