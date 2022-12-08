Console.Clear();

Console.Write("Добро пожаловать на черничную ферму!! Сколько у вас будет кустов с ягодами:  ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] coll)
{
    int index = 0;
    while (index < n)
    {
        Console.Write($"Количество ягод на {index + 1}-м кусте: ");
        int y = Convert.ToInt32(Console.ReadLine());
        coll[index] =  y;
        index++;
    }
}
int[] array = new int[n];

FillArray(array);

int index = 1;
int max = 0;
int best = 0;
while (index < (n -1))
{
    if (array[index - 1] + array[index] + array[index + 1] > max)
    {
        max = (array[index - 1] + array[index] + array[index + 1]);
        best = index;
    }
    index++;
}

Console.WriteLine($"Лучше всего собирать на {best + 1}-м кусте!! Вы соберете: {array[best - 1] + array[best] + array[best + 1]} ягод черники !!!");