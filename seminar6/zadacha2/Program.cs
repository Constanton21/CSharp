// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine(arrayToNull(num));

// int arrayToNull(int numer)
// {
// List<int> mass = new List<int>();
// while (numer > 1)
// {
// mass.Add(numer % 2);
// numer = numer / 2;
// }
// mass.Add(1);
// mass.Reverse();
// return (int.Parse(String.Join("", mass)));
// }

Console.Clear();
int number = int.Parse(Console.ReadLine());
string res = DecToNum(number, 2);
Console.WriteLine($"{number} -> {res}");

string DecToNum(int decNumber, int otherSystem)
{
string res = "";
string nums = "0123456789ABCDEF";
while (decNumber > 0)
{

res = nums[decNumber%otherSystem] + res;
decNumber /= otherSystem;
}
return res;
}