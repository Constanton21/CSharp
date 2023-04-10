/* **Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

Console.Clear();

int[] array = NewArray(8, -10, 10);
Console.WriteLine(String.Join(", ",  array));
Console.WriteLine(String.Join(", ",  PlusMinus(array)));

int[] NewArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);   
    }
    return array;
}

int[] PlusMinus(int[] array){

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i]*(-1);
}
return array;
}
