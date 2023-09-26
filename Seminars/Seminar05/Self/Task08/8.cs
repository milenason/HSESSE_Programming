using System;

class Program
{


    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        string l = Console.ReadLine();
        int L = int.Parse(l);
        if (k > L)
        {
            Console.WriteLine("Некорректные данные");
        }
        for (int i = 0;  i < l.Length - k; i ++)
        {
            L = L / 10;
        }
        Console.WriteLine(L);
        Console.ReadKey();
    }
}