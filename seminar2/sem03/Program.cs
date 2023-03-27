// команды для удобства
//Console.Clear();
//int a = new Random().Next(100, 999);
//Console.Write($"{b} ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = int.Parse(Console.ReadLine());     ||   &&

int a = int.Parse(Console.ReadLine());
 if ((a % 7 == 0) && (a % 23 == 0))
 {
    Console.Write($"{a} кратно 7 и 23");
 }else 
{ 
    Console.Write($"{a} не кратно одновременно 7 и 23");
}