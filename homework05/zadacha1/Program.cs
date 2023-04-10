// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = NewArray(20, 100, 999);
Console.WriteLine($"[{String.Join(", ",  array)}]");
int count = 0;
Console.WriteLine($"Количество четных чисел ={Chetkie (array, count)}");


int[] NewArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);   
    }
    return array;
}

int Chetkie (int[] array, int count)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    } return count;
}