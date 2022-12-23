Console.Clear();
Console.Write("Введите число: ");
string? n =  Console.ReadLine();
int sum = 0;
int y = n.Length;
int i = 0;
while (i < y)
{
sum = sum + (Convert.ToInt32(n[i].ToString()));
i++;
}
Console.WriteLine(sum);