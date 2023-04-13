// создание рандомного массива 
int[] NewArray(int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max+1);   
    }
    return array;
}

// bool правыда неправда
bool FindCount(int[] array, int el){

foreach (var name in array)
{
    if (el == name) return true;
}
return false;
}

// перевод строки вводимых элементов массива в массив
int[] GetArrayFromString(string StringArray)
{
    string[] nums = StringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i=0; i < nums.Length; i++){
        res[i] = int.Parse(nums[i]);
    } return res;
}

// выводы и вводы
Console.Clear();
Console.Write("Введите : ");
Console.WriteLine($"[{String.Join(", ",  array)}]");
string[] str = Console.ReadLine().Split(' ');
int n = int.Parse(Console.ReadLine());
Console.Write($"{b} ");
Console.WriteLine(String.Join(" ", array));
int a = new Random().Next(100, 999); //создание рандомного числа
using System; // вводим вначале перед двухмерными массивами
using static System.Console;  
Write("Введите количество строк массива: "); int rows=int.Parse(ReadLine()); 
Write("Введите количество столбцов массива: "); int columns=int.Parse(ReadLine()); 

//


// перевод в целочисленные 
int b = Convert.ToInt32(Console.ReadLine());
int a = int.Parse(Console.ReadLine());    

// мат функции ||   &&
if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

// Считаем количество попаданий в предел массива
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