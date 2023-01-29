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
    
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1)-1; j++)
        {
            int temp = 0;
            if (array[i,j] < array[i, j+1])
            {
                temp = array[i,j];
                array[i,j] = array[i, j+1];
                array[i, j+1] = temp;
            }
            else if (array[i,0]<array[i,j])
            {
                temp = array[i,0];
                array[i,0] = array[i, j];
                array[i, j] = temp;
            }
            else continue;
        }
    }
}
int[,] array = new int [4,3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRow(array);
PrintArray(array);