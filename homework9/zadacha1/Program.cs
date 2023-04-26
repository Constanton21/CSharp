// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);
WriteNumUmen(number1, number2);

void WriteNumUmen(int number1, int number2)
{
    if (number2  == number1)
    {
        Write(number2);
    } else {Write(number2 + ", ");
    WriteNumUmen(number1, --number2);}
}