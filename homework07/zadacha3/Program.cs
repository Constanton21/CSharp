﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using System;
using static System.Console;

Clear();
int[,] array = GetArray(5, 8, 0, 9);
PrintArray(array);
WriteLine();
PrintAverage(array);




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
            Write($"{inArray[i, j]}     ");
        }
        WriteLine();
    }
}

void PrintAverage(int[,] newArray)
{ WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < newArray.GetLength(1); j++)
    {   double sum = 0;
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            
        }
        double average = sum / newArray.GetLength(0);
        Write($"{Math.Round(average, 2)}; ");
        }
}
