void InputMatrix(int[,,] matrix)
{   
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = count++;
            Console.WriteLine($"{matrix[i, j, k]} ({i} {j} {k})");
            }
        }
    }
}

Console.Clear();
Console.WriteLine();
int SizeMax = new Random().Next(2, 4);
int[,,] matrix = new int[SizeMax, SizeMax, SizeMax];
InputMatrix(matrix);
