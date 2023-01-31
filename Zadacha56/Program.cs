    
int[,] array = new int[5,4];
FillArray(array);
PrintArray(array);
int minSum = 0;
int sumLine = CheckRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = CheckRow(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}
Console.WriteLine($"\n{minSum+1} - наименьшая сумма элементов ({sumLine}) ");

int CheckRow(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr) 
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,10);
        }
    }
}
