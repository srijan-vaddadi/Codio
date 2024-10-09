using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer (1 to 5): ");
        int x = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            default:
                Console.WriteLine("undefined");
                break;
        }
    }
}
