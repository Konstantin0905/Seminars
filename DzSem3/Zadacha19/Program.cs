Console.Clear();
Console.Write("Введите число: ");
string? n =  Console.ReadLine();

if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Ура, ваше число - палиндромом!!");
else 
    Console.WriteLine("Ваше число - НЕ палиндромом ;(");