Console.Clear();

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

// for (int i = (2); i <= n; i += 2)

int i = 2;
while (i <= n)
{
    Console.Write($"{i} ");
i += 2;
}