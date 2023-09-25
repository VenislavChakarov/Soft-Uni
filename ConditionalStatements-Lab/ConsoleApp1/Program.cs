using System;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string correct = "s3cr3t!P@ssw0rd";

            if (password == correct)
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
       
            
        }   
    }
}
