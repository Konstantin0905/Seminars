Console.Clear();

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100;
int n2 = n % 10;

//Console.WriteLine(n2);
//Console.WriteLine(n1);

    Console.WriteLine(((n - n1*100) - n2)/10 );
