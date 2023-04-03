Console.Clear();
Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine());
int n5 = N%10;
int N0 = N/10;
int n4 = N0%10;
N0 = N0/10;
int n3 = N0%10;
N0 = N0/10;
int n2 = N0%10;
N0 = N0/10;
int n1 = N0%10;
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine($"Да, число {N} является палиндромом ");
} else Console.WriteLine($"Нет, число {N} не палиндром ");

