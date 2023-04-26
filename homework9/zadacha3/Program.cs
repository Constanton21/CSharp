// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);
Write($"{Acerman(number1, number2)}");

int Acerman(int number1, int number2)
{
        if (number1 == 0) {
            return number2 + 1;
        } else if (number2 == 0) {
            return Acerman(number1 - 1, 1);
        } else {
            return Acerman(number1 - 1, Acerman(number1, number2 - 1));
        }
}