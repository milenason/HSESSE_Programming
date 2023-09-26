using System;

class Program
{
    public static void Main()
    {
        int num = 0;
        int sum = 0;
        do
        {
            if (num == 20)
                continue;
            if (num % 3 == 0 && num % 2 == 0 && num != 20)
            {
                Console.WriteLine($"Число {num}");
            }
            else
            {
                Console.WriteLine($"Число {num} не соответствует условию");
            }
        } while (++num <= 50);
        Console.ReadKey();
    }

}