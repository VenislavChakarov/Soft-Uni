namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggest = string.Empty;
            double min = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double radios = double.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());
                double sum = Math.PI * Math.Pow(radios, 2) * hight;
                if (sum > min)
                {
                    biggest = name;
                    min = sum;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}