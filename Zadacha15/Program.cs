Console.Clear();
Console.Write("Введите день недели: ");

int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.Write("В неделе всего 7 дней!!\nВведите день недели:");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n < 6)
    Console.WriteLine("Будний день ;(");
else
    Console.WriteLine("Ура, ВЫХОДНОЙ!!");