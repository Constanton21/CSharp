// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = a % 100;
int c = b / 10;
Console.Write($"Вторая цифра числа {a} -> {с} ");