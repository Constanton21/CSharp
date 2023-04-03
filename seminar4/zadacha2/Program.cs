Console.WriteLine("Напищите число n: ");
int n = int.Parse(Console.ReadLine());
int res = 1;

Console.WriteLine($"произведение чисел от 1 до {n} -> {Proizv(res)}");


int Proizv(int res){
  for (int i=1; i<=n; i++){
    res =res*i;
  }
  return res;
}