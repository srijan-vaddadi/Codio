using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer for x: ");
        int x = int.Parse(Console.ReadLine()); 

        if ((x >= 0 && x <= 25) || (x >= 75 && x <= 100))
        {
            Console.WriteLine($"{x} is between 0 and 25 or 75 and 100.");
        }
    }
}
