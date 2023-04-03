Console.Clear();
Console.WriteLine("Введите число n: ");
int n1 = int.Parse(Console.ReadLine()); //вводимое число
int res = 0;// сумма
int n = n1;//меняющееся значение
Console.WriteLine($"Сумма чисел числа {n1} -> {SumCifr(res)}");


int SumCifr(int res){
  while (n >= 1){
    int i = n%10;
    res =res+i;
    n = n/10;
  }
  return res;
}