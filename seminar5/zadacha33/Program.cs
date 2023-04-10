/* **Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] String.Join(", ", array)*/

Console.Clear();

int[] array = NewArray(10, 0, 20);
Console.WriteLine(String.Join(", ",  array));
Console.Write("Введите число для поиска: ");
int n = int.Parse(Console.ReadLine());
if (FindCount(array, n)) {
    Console.WriteLine("Yes");
} else {Console.WriteLine("No");}

int[] NewArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);   
    }
    return array;
}

bool FindCount(int[] array, int el){

foreach (var name in array)
{
    if (el == name) return true;
}
return false;
}
