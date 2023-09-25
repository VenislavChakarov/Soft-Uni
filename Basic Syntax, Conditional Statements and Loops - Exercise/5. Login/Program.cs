string username = Console.ReadLine();
string passwrod = string.Empty;

for (int i = username.Length - 1; i >= 0; i--)
{
    passwrod += username[1];
}

int atempts = 0;
string logins = string.Empty;

while (((logins = Console.ReadLine()) != passwrod) || atempts < 4)
{
    atempts++;
    Console.WriteLine("Incorrect password. Try again.");
}

if (atempts == 4)
{
    Console.WriteLine($"User {username} blocked!");
}
else
{
    Console.WriteLine($"User {username} logged in.");
}

