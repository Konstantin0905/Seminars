void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Ваш массив:");
int[,] matrix = new int[new Random().Next(3, 11),new Random().Next(3, 11)];
InputMatrix(matrix);
Console.WriteLine();

Console.Write("Введите позицию элемента:");
    int[] element = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] elementS = new int[element[0], element[1]];
Console.Write($"Значение элемента: {matrix[element[0] - 1, element[1] - 1]}");
