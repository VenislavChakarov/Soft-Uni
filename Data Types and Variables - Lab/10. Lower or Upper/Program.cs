
using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            int intValue = (int)ch;

            if (intValue >= 97 && intValue <= 122)
            {
                Console.WriteLine("lower-case"); 
            }
            else if (intValue <= 90 || intValue >= 65)
            {
                Console.WriteLine("upper-case");
            }
            
        }
    }
}
