Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.Write($"число {a} четное");
} else 
{
    Console.Write($"число {a} нечетное");
}