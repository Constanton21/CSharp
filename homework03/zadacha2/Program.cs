// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))
Console.Clear();
Console.WriteLine("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

Console.Write($"d={d:f2}");