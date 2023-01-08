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


void OutputNewMatrix(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++ )
        {
            sum += matrix[i, j];
        }
    Console.Write($"{Math.Round(sum / matrix.GetLength(0), 1)} \t");
    sum = 0;
    }
}

Console.Clear();
Console.WriteLine("Ваш массив:");
int[,] matrix = new int[new Random().Next(3, 7),new Random().Next(3, 7)];
InputMatrix(matrix);
Console.WriteLine();
OutputNewMatrix(matrix);