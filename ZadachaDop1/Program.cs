Console.Clear();


int x = 0;
int y = 0;
int z = 0;
int n = Convert.ToInt32(Console.ReadLine());

while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
        
        if (n > x)
        {
            x = n;
            
                if (y < x)
                {
                    z = y;
                    y = x;
                    x = z;
                }
                
        }


}
Console.WriteLine($"{x}");
