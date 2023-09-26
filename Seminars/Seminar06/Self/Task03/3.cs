using System;

class Program
{


    public static void Main()
    {

        for (int i = 2000; i < 3000; i++)
        {
            int f = i / 1000;
            int s = (i % 1000) / 100;
            int t = (i % 100) / 10;
            int l = i % 10;
            if (f != s && s != t && t != l && f != l && f != t && s != l && s != t)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}