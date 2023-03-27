Console.Clear();
int a = new Random().Next(100, 999);
Console.WriteLine(a);
int b = a % 10;
int c = a/100;
Console.Write(c);
Console.WriteLine(b);
int res = c * 10 + b;
Console.WriteLine($"{a} -> {res}");
