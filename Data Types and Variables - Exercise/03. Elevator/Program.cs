double people = double.Parse(Console.ReadLine());
double capacity = double.Parse(Console.ReadLine());

int courses = (int)Math.Ceiling((double)people / capacity);

Console.WriteLine(courses);