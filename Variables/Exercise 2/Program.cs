using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter length b: ");
        double b = double.Parse(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b);

        double area = 0.5 * a * b;

        Console.WriteLine($"Length of c is {c:F3}");

        Console.WriteLine($"Area is {area:F2}");
    }
}
