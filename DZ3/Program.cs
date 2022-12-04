Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine("Ваше число четное!");
else
    Console.WriteLine("Ваше число нечетное! ");
