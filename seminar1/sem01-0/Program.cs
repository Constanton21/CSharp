Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sqr = a * a;
Console.WriteLine($"Квадрат числа {a} равен {sqr}");
int sqr1 = Convert.ToInt32(Math.Pow(a, 3));
Console.WriteLine($"Куб числа {a} равен {sqr1}");

