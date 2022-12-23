Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
int i = 1;
while (i <= b)
{
    result = result * a;
    i++;
}
Console.WriteLine(result); 