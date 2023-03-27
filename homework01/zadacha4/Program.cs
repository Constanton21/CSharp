Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;
while ( b <= a )
{
    Console.Write($"{b} ");
    b=b+2;
}