// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
} else 
{ 
    int b = a % 1000;

}
