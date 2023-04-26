// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);
Write($"{SumNumbers(number1, number2)}");

int SumNumbers(int number1, int number2)
{   
    if (number1  == number2)
        return number1;
    return (number1 + SumNumbers(++number1, number2));
}
