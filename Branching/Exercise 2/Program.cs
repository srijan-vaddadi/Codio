using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer for x: ");
        int x = int.Parse(Console.ReadLine()); 

        if (x % 5 == 0)
        {
            Console.WriteLine($"{x} is divisible by 5.");
        }
        else
        {
            Console.WriteLine($"{x} is not divisible by 5.");
        }
    }
}
