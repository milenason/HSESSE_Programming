using System;

class Program
{
    public static void Main()
    {
        double a, b, c;
        Console.WriteLine("Введите a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите c: ");
        c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine($"x = {-c / b}");
        }
        else if (b == 0)
        {
            Console.WriteLine($"x = {Math.Sqrt(-c / a)}");
        }
        else if ((b * b - 4 * a * c) < 0)
        {
            Console.WriteLine("Нет действительных корней");
        }
        else
        {
            Console.WriteLine($"x1 = {(-b + Math.Sqrt(b * b - 4 * a * c)) / 2*a}" +
                $"x2 = {(-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a}");
        }
    }
}