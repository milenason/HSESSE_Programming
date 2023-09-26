using System;

class Program
{
    public static double Calculate(char operation, double a, double b)
    {
        switch (operation)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '/': return a / b;
            case '*': return a * b;
        }
        return default;
    }

    public static void Main()
    {
        double eps = 1e-2;
        string operations = "+-/*";

        for (int i = 0; i < 4; i++)
        {
            double result1 = Calculate(operations[i], 1, 2);
            for (int j = 0; j < 4; j++)
            {
                double result2 = Calculate(operations[j], result1, 3);
                for (int k = 0; k < 4; k++)
                {
                    double result3 = Calculate(operations[k], result2, 4);
                    for (int t = 0; t < 4; t++)
                    {
                        double result4 = Calculate(operations[t], result3, 5);
                        for (int l = 0; l < 4; l++)
                        {
                            double result5 = Calculate(operations[l], result4, 6);
                            if (result5 <= 35 + eps && result5 >= 35 - eps)
                            {
                                Console.WriteLine($"((((1 {operations[i]} 2) {operations[j]} 3) {operations[k]} 4) {operations[t]} 5) {operations[l]} 6 = {result5}");
                            }
                        }
                    }
                }
            }
        }
    }
}