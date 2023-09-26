using System;

class Program
{


    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        double z = 0;
        for (double i = 1; i < k + 1; i ++)
        {
            z += 1 / i;
        }
        Console.WriteLine(z);
        Console.ReadKey();
    }
}