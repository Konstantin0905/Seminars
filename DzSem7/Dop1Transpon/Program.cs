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
    int temp = 0;
    int k = matrix.GetLength(0) ;
    for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
                    matrix[matrix.GetLength(0) - 1 - i, j] = temp;
            }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Ваш массив:");
int[,] matrix = new int[new Random().Next(3, 7),new Random().Next(3, 7)];


InputMatrix(matrix);
Console.WriteLine("Транспонированный относительно горизонтали: ");
OutputNewMatrix(matrix);