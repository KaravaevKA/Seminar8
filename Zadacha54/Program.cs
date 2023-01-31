﻿void PrintArray(int[,] matr)
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
        for (int j =0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(1)-1; k++)
            {
                
                if (array[i,k] < array[i, k+1])
                {
                    int temp = array[i,k+1];
                    array[i,k+1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int [4,3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRow(array);
PrintArray(array);