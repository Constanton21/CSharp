Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine($"Да, {a} является квадратом {b}");
}
else 
{
    Console.WriteLine($"Нет, {a} не является квадратом {b}");
}
