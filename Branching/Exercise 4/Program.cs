using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a color: ");
        string x = Console.ReadLine();

        if (x.ToLower() == "red" || x.ToLower() == "blue" || x.ToLower() == "yellow")
        {
            Console.WriteLine($"{x} is a primary color.");
        }
        else
        {
            Console.WriteLine($"{x} is not a primary color.");
        }
    }
}
