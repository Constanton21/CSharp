// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write("+");
//Console.Write($"{b} ");
int b = Convert.ToInt32(Console.ReadLine());

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