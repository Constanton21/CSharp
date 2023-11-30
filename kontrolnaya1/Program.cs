// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;

Console.Clear();

string[] inputArray = { "Hello", "2", "world", ":-)" };
string[] resultArray = Filter(inputArray);

Console.WriteLine("Исходный массив: [" + string.Join(", ", inputArray) + "]");
Console.WriteLine("Новый массив: [" + string.Join(", ", resultArray) + "]");

string[] Filter(string[] inputArray)
{
    string[] resultArray = new string[inputArray.Length];
    int index = 0;
    foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }
    return resultArray;        
}
