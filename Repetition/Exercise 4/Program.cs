using System;

class Program
{
    static void Main()
    {
        double bread = 1.50;
        double targetPrice = 1.50 * 2;
        int year = 0;

        while (bread < targetPrice)
        {
            bread = bread * 1.08;
            year++; 
        }

        Console.WriteLine($"It will take {year} years for the price of bread to double.");
    }
}
