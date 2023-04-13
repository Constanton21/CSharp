// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();
double[] array = NewArray(10, -200, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
double diff = 0;
Console.WriteLine($"Разница между максимальным и минимальным равна {RaznicaMinMax(array, diff)}");

double[] NewArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

double RaznicaMinMax(double[] array, double diff)
{
    double MaxEl = array[0];
    double MinEl = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxEl)
        {
            MaxEl = array[i];
        }
        if (array[i] < MinEl)
        {
            MinEl = array[i];
        }
    }
    diff = MaxEl - MinEl;
    return diff;

}