// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

Console.Clear();
int f1 = 3; //скорость друга 1
int f2 = 2; //скорость друга 2
int d = 15; //скорость собаки
double s = 1000; //расстояние между друзьями
int r = 4; // расстояние когда встретились
int count = 0; // счетчик перемещений собаки
int v = 2; //направление собаки
while (s > r)
{
    if (v == 2)
    {
        s = s - s/(f2 + d) * (f1 + f2);
        v = 1;
        count++;
    } else
    {
        s = s - s/(f1 + d) * (f1 + f2);
        v = 2;
        count++;
    }
}
Console.Write($"собака пробежит {count} раз");