// **Задача 48:** Задайте 
// двумерный массив размера m на n, каждый элемент
//  в массиве находится по формуле: A[i, j] = i + j. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
using System; 
using static System.Console;

Clear();

Write("Введите количество строк массива (m): ");
int rows=int.Parse(ReadLine()!);

Write("Введите количество столбцов массива (n): ");
int columns=int.Parse(ReadLine()!);

    double[,] array = GetArray(rows, columns);
    PrintArray(array);


double[,] GetArray(int m, int n)
    {
        double[,] result = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
            result[i, j] = new Random().NextDouble()*5;
            }
        }
        return result;
    }


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{Math.Round(inArray[i,j], 2)} ");
        }
        WriteLine();
    }
}