using System;

class Program
{
    public static void Main()
    {
        double x, y;
        Console.Write("Введите x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        y = double.Parse(Console.ReadLine());

        if (y > 0 && x * x + y * y > 1 * 1 && x * x + y * y < 2 * 2)
        {
            Console.WriteLine($"Точка [{x}, {y}] попала внутрь области");
        }
        else if (y == 0 && x * x + y * y > 1 * 1 && x * x + y * y < 2 * 2
            || y > 0 && x * x + y * y == 1 * 1 && x * x + y * y < 2 * 2
            || y > 0 && x * x + y * y > 1 * 1 && x * x + y * y == 2 * 2)
        {
            Console.WriteLine($"Точка [{x}, {y}] попала на границу области");
        }
        else 
        {
            Console.WriteLine($"Точка [{x}, {y}] попала за границу области");
        }

    }
}