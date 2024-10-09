using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        string x = Console.ReadLine();

        if ("aeiou".Contains(x))
        {
            Console.WriteLine($"{x} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{x} is not a vowel.");
        }
    }
}
