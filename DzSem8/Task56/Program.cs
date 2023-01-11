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

Console.Clear();
Console.WriteLine("Начальый массив:");
int SizeMax = new Random().Next(2, 10);
int[,] matrix = new int[SizeMax, SizeMax];
InputMatrix(matrix);

int n = 0;
int[] SumRow = new int[SizeMax];
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            n = i;
            SumRow[n] += matrix[i, j];
        }
    }   

            int MinRow = SumRow[0];
            int index = 0;
            for (int z = 0; z < SumRow.Length; z++)
            {
                if (MinRow > SumRow[z])
                    {
                    MinRow = SumRow[z];
                    index = z;
                    }
            }
            Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1}");


