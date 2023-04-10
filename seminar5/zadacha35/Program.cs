/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5
*/

Console.Clear();
int[] array = NewArray (123);
Console.WriteLine($"[{String.Join(", ",  array)}]");
int count = 0;
Console.WriteLine($"в массиве из 123 элементов число в пределе от 10 до 99 попадает {CountElements(array, count)} раз");

int[] NewArray(int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(300);   
    }
    return array;
}

int CountElements(int[] array, int count)
{
for (int i = 0; i <array.Length; i++)
  {
  if (array[i] > 9 && array[i] < 100)
    {
      count ++;
    }
  } return count;
} 

