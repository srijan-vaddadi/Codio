using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base: ");
        int baseValue = int.Parse(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result *= baseValue;
        }

        Console.WriteLine($"{baseValue}^{exponent} = {result}");
    }
}
