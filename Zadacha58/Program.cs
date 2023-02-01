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

int[,] GetArray(int m, int n, int min, int max) 
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(min,max+1);
        }
    }
    return result;
}


int[,] MatrixMultiplication(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k<matrA.GetLength(1); k++)
            {
                matrC[i,j] += (matrA[i,k]*matrB[k,j]);
            }
        }
    }
    return matrC;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int rowA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columnA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int rowB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columnB = int.Parse(Console.ReadLine());

int[,] A = GetArray(rowA, columnA, 0, 10);
int[,] B = GetArray(rowB, columnB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(MatrixMultiplication(A,B));