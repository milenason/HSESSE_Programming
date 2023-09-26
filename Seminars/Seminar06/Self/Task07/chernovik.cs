using System;

class Program
{


    public static void Main()
    {
        string s = Console.ReadLine();
        if (int.TryParse(s, out int i))
            Console.WriteLine($"Это целое число: {i}");
        else
            Console.WriteLine("Введенная строка вовсе не число.");
        Console.ReadKey();


        bool ii = true;
        while (ii)
        {
            Console.Clear();
            try
            {
                decimal a = decimal.Parse(Console.ReadLine());
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
                ii = false;
            }
            catch (Exception ex)
            {
                ii = true;
                Console.WriteLine("некорректные данные");
            }
            
        }
        Console.ReadKey();


        do
        {
            bool ii = true;
            bool m = true;
            while (ii)
            {
                Console.Clear();
                try
                {
                    decimal a = decimal.Parse(Console.ReadLine());
                    decimal b = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(a / b);
                    m = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("некорректные данные");
                    m = true;

                }
                if (m == false)
                {
                    ii = false;
                }

            }
            Console.WriteLine("Для выхода из программы нажмите ESC...");

        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}