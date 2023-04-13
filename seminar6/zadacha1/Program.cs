// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.

Console.Clear();

Console.Write("Введите длины сторон треугольника через пробел: ");

string[] str = Console.ReadLine().Split(' ');
int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);

if (IsTriangle(a, b, c)){
    Console.Write("Yes");
} else {
    Console.Write("No");
}

bool IsTriangle(int a, int b, int c){
return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}