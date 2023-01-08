void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

void FindGoodDay(int[] array)
 {
    Console.Write("В эти дни Вася получил Четверку: ");
    int GoodDay = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            {
            GoodDay++;
            Console.Write($"{array[i]} "); 
            }   
    }
   Console.WriteLine(); 
   Console.WriteLine($"Итого Четверок: {GoodDay}");
   int GD = GoodDay;
}

void FindBadDay(int[] array)
 {
    Console.Write("В эти дни Вася получил Тройку: ");  
    int BadDay = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            {
            BadDay++;
            Console.Write($"{array[i]} "); 
            }   
    }
   Console.WriteLine(); 
   Console.WriteLine($"Итого троек: {BadDay}");
   int BD = BadDay;
}

int n = 10;    //new Random().Next(1, 10);
int[] array = new int [n];
int GD = 0;
int BD = 0;
InputArray(array);

Console.WriteLine($"Дни когда Вася получил оценки: [{string.Join(", ", array)}]");

FindGoodDay(array);
FindBadDay(array);

if (GD >= BD)
    Console.WriteLine($"{GD} Василий за четверть получит ЧЕТВЕРКУ!!");
else 
    Console.WriteLine($"Васька получит ТРОЯК (((");
