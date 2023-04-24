using System;
using static System.Console;
Clear();
Write($"Введите размер матрицы: ");
int size = int.Parse(ReadLine());
int[,] SpringArray = GetArray(size);
PrintArray(SpringArray);


int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int number = 1;

    while (size != 0)
    {
        int k = 0;
        do
        {
            result[i, j++] = number;
            number++;
        } while (++k < size - 1);
        for (k = 0; k < size - 1; k++)
        {
            result[i++, j] = number;
            number++;
        }
        for (k = 0; k < size - 1; k++)
        {
            result[i, j--] = number;
            number++;
        }
        for (k = 0; k < size - 1; k++)
        {
            result[i--, j] = number;
            number++;
        }
        ++i;
        ++j;
        if (size < 2)
        {
            size = 0;
        } else
        {
            size -=2;
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