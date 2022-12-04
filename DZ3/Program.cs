Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine($"Ваше число {n} - чётное!");
else
    Console.WriteLine($"Ваше число {n} - нечётное! ");
