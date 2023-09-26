using System;

class Program
{


    public static void Main()
    {
        string a = Console.ReadLine();
        int b = int.Parse(a);
        double n = 0;
        double s = a.Length - 1;
        for (int i = 1; i <= a.Length; i++)
        {
            if (b % 10 == 0)
            {
                b = b / 10;
            }
            double x = Math.Pow(10.0, s);
            n = n + (b % 10) * x;
            s = s - 1;
            b = b / 10;
            
        }
        Console.WriteLine(n);
        Console.ReadKey();
    }
}