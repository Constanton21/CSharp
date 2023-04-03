Console.Clear();
int[] array = RandomArray(8);
Console.WriteLine($"[{String.Join(", ",  array)}]");

for (int i = 0; i < array.Length; i++) {
    Console.Write($"{array[i]}, ");
}
//Console.WriteLine($"{array[array.Length-1]} ");

int[] RandomArray (int size){
    int[] res = new int [size];
  for (int i=0; i<size; i++){
    res[i] = new Random().Next(100);
  }
  return res;
}