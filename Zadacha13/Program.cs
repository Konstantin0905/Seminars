Console.Clear();
Console.Write("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int z = 1;
int x = 1;

if (n > 99)
{
    while (z != 0)  
    {
        z = n / (100*x);
        x = x*10;
    }
int n1 = n / (x/10);  
int n2 = n / (x/100);
    Console.WriteLine(n2 - n1*10); 
    }
else
Console.WriteLine("Третьей цифры нет!");
