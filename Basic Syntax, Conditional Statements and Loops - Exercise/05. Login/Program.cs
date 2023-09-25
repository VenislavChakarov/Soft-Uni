

using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string passwrod = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                passwrod += username[i];
            }

            int atempts = 0;

            while (atempts < 4)
            {
                string logins = Console.ReadLine();
                atempts++;
                if (logins == passwrod)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (atempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (logins != passwrod)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            
        }
    }
}
