Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine($"[{string.Join(", ", array)}]");
