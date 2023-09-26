using System;

class Program
{
    public static double F(double x) => x * x;

    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double result = 0;
        for (double xi = 0; xi < a; xi += a / n)
        {
            result += F((xi + xi + a / n) / 2) * (xi - (xi - a / n));
        }
        Console.WriteLine(result);
        Console.ReadKey();
    }
}