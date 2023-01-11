void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void OutputNewMatrix(int[,] matrix1, int[,] matrix2, int[,] matrixResult)
{ 
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write($"{matrixResult[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Матрица 1:");
int SizeMax = new Random().Next(3, 3);
int[,] matrix1 = new int[SizeMax, SizeMax];
int[,] matrix2 = new int[SizeMax, SizeMax];
int[,] matrixResult = new int[SizeMax, SizeMax];
InputMatrix(matrix1);
Console.WriteLine("Матрица 2:");
InputMatrix(matrix2);
Console.WriteLine("Результирующая матрица:");
OutputNewMatrix(matrix1, matrix2, matrixResult);