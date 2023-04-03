// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))
Console.Clear();
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
for (int i = 0; i <= N; i++)
Console.Write($"{Math.Pow(i, 3)} ");