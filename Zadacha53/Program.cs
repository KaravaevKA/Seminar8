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
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void ChangeRow(int [,] array)
{
    int temp = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        temp = array[0, i]; 
        array [0, i] = array [array.GetLength(0)-1, i];
        array [array.GetLength(0)-1, i] = temp;
    }
}
int[,] array = new int [5,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRow(array);
PrintArray(array);
