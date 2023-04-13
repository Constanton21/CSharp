// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine()!); //вводимое число
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine()!); //вводимое число
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine()!); //вводимое число
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine()!); //вводимое число


double x = 0;
double y = 0;
x = FindX(x);
y = FindY(y);
Console.Write($"Точка пересечения двух прямых ({x}; {y})");

double FindX(double x){
    x = (b2-b1)/(k1-k2);
return x;
}

double FindY(double y) {
    y = (k1 * x) + b1;
return y;
}