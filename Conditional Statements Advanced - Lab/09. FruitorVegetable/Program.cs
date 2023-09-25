using System;

namespace _09._FruitorVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {

                string food = Console.ReadLine();
            switch (food)
            {
                case "banana":
                case "kiwi":
                case "apple":
                case "cherry":
                case "lemon":
                case "grapes": Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot": Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
