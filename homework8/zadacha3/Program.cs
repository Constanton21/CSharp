// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();
Write("Введите количество строк массива B и столбцов массива A: ");
int RС = int.Parse(ReadLine());
Write("Введите количество строк массива A: ");
int RA = int.Parse(ReadLine());
Write("Введите количество столбцов массива B: ");
int CB = int.Parse(ReadLine());


int[,] A = GetArray(RA, RС, 0, 10);
int[,] B = GetArray(RС, CB, 0, 10);
PrintArray(A);
WriteLine();
PrintArray(B);
WriteLine();
PrintArray(GetArrayProizvMatrix(A,B));



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
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

int[,] GetArrayProizvMatrix(int[,] ArrA, int[,] ArrB)
{
    int[,] ArrProizv = new int[ArrA.GetLength(0), ArrB.GetLength(1)];
    for (int i = 0; i < ArrA.GetLength(0); i++)
    {
        for (int j = 0; j < ArrB.GetLength(1); j++)
        {
            for (int k = 0; k < ArrA.GetLength(1); k++)
            {
                ArrProizv[i, j] += ArrA[i, k] * ArrB[k, j];
            }
        }
    }
    return ArrProizv;
}