using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        double l = double.Parse(Console.ReadLine());
        if (l > 0 && n >= 1 && n <= 11)
        {
            double s = (n * l * l) / (4 * Math.Tan(Math.PI/n));
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine("Некорректные значения");
        }
        
        }
}