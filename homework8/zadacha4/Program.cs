using System;
using static System.Console;

Clear();
int[,,] array3 = Get3Array(2, 2, 2, 10, 99);

// int[,,] array3 = {{{11, 12},{21, 22}},
// {{31, 32},{41,42}}};

PrintArray(array3);



int[,,] Get3Array(int m, int n, int t, int min, int max)
{
    int[,,] result = new int[m, n, t];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < t; k++)
            {
                int element = new Random().Next(min, max + 1);
                while (UnicEl(result, element) == false)
                {
                    element = new Random().Next(min, max + 1); 
                }
                // if (UnicEl(result, element)) 
                // {
                //     element = new Random().Next(min, max + 1);  
                // }
                result[i, j, k] = element;
            }
        }
    }
    return result;
}

bool UnicEl(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k] == el) return false;
            }
        }
    }
    return true;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i} {j} {k}); ");
            }Console.WriteLine();
        }
    }
}
