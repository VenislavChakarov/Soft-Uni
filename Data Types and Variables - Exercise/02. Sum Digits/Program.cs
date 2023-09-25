string n = Console.ReadLine();
int num = int.Parse(n);
int sum = 0;

for (int i = 0; i < n.Length; i++)
{
    int digit = num % 10;
    sum += digit;
   num /= 10;
    
}
Console.WriteLine(sum);