using System;

class Program
{


    public static void Main()
    {
        decimal x = 1;
        decimal y = 0;
        int a = 0;
        do
        {
            y += 1 / (x * (x + 1) * (x + 2));
            Console.WriteLine(y);
            x += 1;
        } while (++a <= 50);
        Console.ReadKey();
    }
}