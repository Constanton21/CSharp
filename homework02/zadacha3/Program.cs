// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

Console.Clear();
Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if ((a < 1) || (a >7))
{
    Console.WriteLine("Неправильный номер дня недели, введите от 1 до 7");
    a = int.Parse(Console.ReadLine());
} if ((a == 6) || (a ==7)) {
    Console.WriteLine("Выходной");
} else {
    Console.Write("Будничный день");
}

