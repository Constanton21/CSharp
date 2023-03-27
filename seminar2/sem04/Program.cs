// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&
// if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

 if ((Convert.ToInt32(Math.Pow(a, 2)) == b) || (b * b == a))
 {
    Console.Write($"да");
 }else 
{ 
    Console.Write($"нет");
}

