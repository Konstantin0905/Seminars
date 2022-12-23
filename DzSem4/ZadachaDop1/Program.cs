Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [n];
int [] NewArray = new int [Array.Length];
    for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"Введите {i+1}-й элемент массива: ");
            Array[i] = Convert.ToInt32(Console.ReadLine());
        }
Console.Write("Введите сдвиг: ");
int y = Convert.ToInt32(Console.ReadLine());
    if (y > 0)
    {
        for (int i = 0; i < y; i++)
            NewArray[i] = Array[Array.Length - y + i];
        for (int i = 0; i < Array.Length - y; i++)
            NewArray[y + i] = Array[i];
        Console.WriteLine($"Начальный массив: [{string.Join(", ", Array)}]");
        Console.WriteLine($"Новый массив: [{string.Join(", ", NewArray)}]");
    }
    else
    {
        y = y * (-1);
        for (int i = 0; i < y; i++)
            NewArray[Array.Length - y + i] = Array[i];
        for (int i = 0; i < Array.Length - y; i++)
            NewArray[i] = Array[y + i];
        Console.WriteLine($"Начальный массив: [{string.Join(", ", Array)}]");
        Console.WriteLine($"Новый массив: [{string.Join(", ", NewArray)}]");
}