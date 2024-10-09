using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the temperature in Celsius: ");

        int celsius = int.Parse(Console.ReadLine());
        int fahrenheit = (9 * celsius / 5) + 32;
        int kelvin = celsius + 273;

        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        Console.WriteLine($"Temperature in Kelvin: {kelvin}");
    }
}
