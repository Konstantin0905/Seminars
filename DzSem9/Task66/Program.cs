int rec(int a, int b)
{
    if (b == a)
        return a;
    return rec(a, b - 1) + b;
}

Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));   
