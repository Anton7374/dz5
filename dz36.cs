int [] GetRandomArray(int lenght, int min, int max)
{
      int [] array = new int[lenght];
      for (int i = 0; i < lenght; i++)
      {
         array[i] = new Random() . Next (min, max + 1);
      }
      return array; 
}

int SumArray(int[] array)
{
    int total = 0;
    for (int i = 1; i < array.Length; i += 2) total += array[i];
    return total;
}
int [] array = GetRandomArray (8, -10, 10);
Console.WriteLine(String.Join("", array));
Console.WriteLine(SumArray(array));