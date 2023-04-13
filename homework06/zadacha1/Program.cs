// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите числа от -100 до 100 через пробел: ");
string[] str = Console.ReadLine().Split(' ');
int[] array = GetArrayFromString(str);
int count = 0;
int N = CountPositiv(array, count);
int m = str.Length;
Console.Write($"из {m} введенных чисел, положительных чисел -> {N} ");

int[] GetArrayFromString(string[] str){
    int[] res = new int[str.Length];
    for (int i=0; i < str.Length; i++){
        res[i] = int.Parse(str[i]);
    } return res;
}

int CountPositiv(int[] array, int count) {
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {count++;
    }
} return count;
}