using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoritBook = Console.ReadLine(); 

            int counter = 0;
            string input = "";

            while (input != "No More Books")
            {
                input = Console.ReadLine();

                if (input == favoritBook) 
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }
                counter++;

            }


        }
    }
}
