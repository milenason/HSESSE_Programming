using System;

public class Example
{
    public static void Main()
    {
        //F = !(p & q) & !(p || !q)
        bool p = false;
        bool q = false;
        do
        {
            do
            {
                bool F = !(p & q) & !(p | !q);
                Console.WriteLine($"p = {p} q = {q} F = {F}");
                q = !q;
            } while (q);
            p = !p;

        } while (p);
        Console.ReadKeyusing System;
	}

}