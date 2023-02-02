Console.Clear();

double RandomDouble( int minBorder, int maxBorder) 
{

    double randomDouble = new Random().NextDouble() * (maxBorder - minBorder) + minBorder;
    return randomDouble;
}

double[] RandomArray(int lenght, int minBorder, int maxBorder)
{
   double[] array = new double [lenght];
   for (int i = 0; i < lenght; i++) array [i] = RandomDouble(minBorder, maxBorder); 
   return array;
}

void SumMinMax (double [ ] array) 
{
   double min = array [0], max = array [0], total = 0;
   for (int i = 0; i < array. Length; i++) 
   {
      if (array[i] < min) min = array [i];
      else if (array [i] > max) max = array [i];
   }

   total = max - min;
   Console.WriteLine($"min = {min} ; max = {max}");
   Console.WriteLine($"min-max = {total}");
}
double[] randomArray =RandomArray(10, 1, 10);
Console.WriteLine(string.Join(" ",randomArray));
SumMinMax(randomArray);
