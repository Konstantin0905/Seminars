void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Мишино фото:");
int[,] foto = new int[new Random().Next(2, 5),new Random().Next(2, 5)];
int[,] negativ = new int[foto.GetLength(0), foto.GetLength(1)];

InputMatrix(foto);
Console.WriteLine("Негатив Мишиной программы: ");
InputMatrix(negativ);

int count = 0;
    for (int i = 0; i < foto.GetLength(0); i++)
    {
        for (int j = 0; j < foto.GetLength(1); j++)
        {
            if (foto[i, j] != negativ[i, j])
            count++;
        }                 
    }
        Console.WriteLine($"Ошибок в Мишиной программе: {count}");