Console.Write("введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int b = a%10;
Console.WriteLine($"последняя цифра числа {a} будет {b}");