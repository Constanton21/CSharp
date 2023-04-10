// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = NewArray(10, -15, 15);
Console.WriteLine($"[{String.Join(", ",  array)}]");
int count = 0;
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях ={SumNechet (array, count)}");


int[] NewArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);   
    }
    return array;
}

int SumNechet (int[] array, int count)
{
    for (int i = 1 ; i < array.Length; i+=2)
    {
         count+=array[i];
    } return count;
}