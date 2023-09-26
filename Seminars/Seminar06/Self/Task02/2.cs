using System;

class Program
{


    public static void Main()
    {
        //((!a & !b | c) | a)
        bool A = false;
        bool B = false;
        bool C = false;
        for (int a = 0; a < 2; a++)
        {
            for (int b = 0; b < 2; b++)
            {
                for (int c = 0; c < 2; c++)
                {
                    if (a == 0)
                    {
                        A = false;
                    }
                    if (b == 0)
                    {
                        B = false;
                    }
                    if (c == 0)
                    {
                        C = false;
                    }
                    if (a == 1)
                    {
                        A = true;
                    }
                    if (b == 1)
                    {
                        B = true;
                    }
                    if (c == 1)
                    {
                        C = true;
                    }
                    bool f = !A & !B | !C | A;
                    if (f == true)
                    {
                        Console.WriteLine($"a = {a} b = {b} c = {c} f = {1}");
                    }
                    if (f == false)
                    {
                        Console.WriteLine($"a = {a} b = {b} c = {c} f = {0}");
                    }

                }
            }
        }
        Console.ReadKey();
    }
}