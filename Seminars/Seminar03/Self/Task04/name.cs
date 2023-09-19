using System;

class Program
{
    public static void Main()
    {
        double x, y;
        Console.WriteLine("Введите x: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите y: ");
        y = double.Parse(Console.ReadLine());

        if (x < y)
        {
            Console.WriteLine($"F = {Math.Sin(x) + (Math.Cos(y) * Math.Cos(y))}");
        }
        else if (x == y)
        {
            Console.WriteLine($"F = {Math.Log(e, Math.Abs(x))}");
        }
        else if (x > y)
        {
            Console.WriteLine($"F = {(Math.Sin(x) * Math.Sin(x)) + Math.Cos(y) +}");
        }

    }
}