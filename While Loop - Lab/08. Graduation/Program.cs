using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sum = 0;
            int lose = 0;
            int classes = 1;

            while (classes <= 12) 
            {
                double gradeForYear = double.Parse(Console.ReadLine());

                if (gradeForYear < 4)
                {
                    lose++;

                    if (lose > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {classes} grade");
                        break;
                    }
                    continue;
                }
                            
                sum = sum + gradeForYear;
                classes++;

            }
            if (classes == 13)
            {
                double avrage = sum / 12.0;

                Console.WriteLine($"{name} graduated. Average grade: {avrage:f2}");
            }
 
        }
    }
}
