// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();
int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
Write("Введите номер строки: ");
int row = int.Parse(ReadLine()!);

Write("Введите номер столбца: ");
int column = int.Parse(ReadLine()!);

if (FindPoz(array, row, column)) {
    Console.WriteLine($"{array[row-1, column-1]}");
} else {Console.WriteLine("такого числа в массиве нет");}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

bool FindPoz(int[,] inArray, int row, int column){
    if (row > inArray.GetLength(0) || column > inArray.GetLength(1)) 
    return false; 
    else return true;
}