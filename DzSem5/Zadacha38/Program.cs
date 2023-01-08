void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (-100 - 101) + 101, 3);
}

void ReleaseArray(double[] array)
{
    double max = -100;
    double min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine($"Максимальный элемент: {max}");
    Console.WriteLine($"Минимальный элемент: {min}");
}

int n = 2;
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
