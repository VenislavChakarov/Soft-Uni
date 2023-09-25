﻿using System;

namespace Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes >= 60) 
            {
                hours += 1;
                minutes -= 60;
            
            }

            if (hours >= 24) 
            {
                hours -= 24;
              
            }

            if (minutes <= 9)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else 
            {
                Console.WriteLine($"{hours}:{minutes}");
            } 

            

            
        }
    }
}
