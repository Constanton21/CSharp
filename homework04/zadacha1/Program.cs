Console.Clear();
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()); //вводимое число
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()); //вводимое число
int res = 1;
Console.WriteLine($"{Math.Pow(a, b)}");   //для проверки выполнения
Console.WriteLine($"{a} в степени {b} -> {ApowB(res)}");

int ApowB(int res){
  while (b > 0){
    res = res * a;
    b--;
      }
  return res;
}
