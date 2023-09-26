using System;

class Program
{
    public static void Main()
    {
        int intCount = 0, doubleCount = 0, otherCount = 0;
        bool isInput = true;
        while (isInput)
        {
            string value = Console.ReadLine();
            try
            {
                int intValue = int.Parse(value);
                intCount++;
                isInput = intValue == 0 ? false : true;
            }
            catch
            {
                try
                {
                    double doubleValue = double.Parse(value);
                    doubleCount++;
                }
                catch
                {
                    otherCount++;
                }
            }
        }
        Console.WriteLine($"int: {intCount,-4} double: {doubleCount,-4} other: {otherCount,-4}");
    }

}