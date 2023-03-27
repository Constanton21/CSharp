//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write("+");
//Console.Write($"{b} ");


//*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
//вляется ли второе число кратным первому. Если второе число не кратно числу первому,
//то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
int a = int.Parse(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a%b == 0)
{
    Console.Write($"{a} кратно числу {b} ");
}else 
{
    int ost = a%b;
    Console.Write($"{a} не кратно числу {b}, остаток {ost}");
}