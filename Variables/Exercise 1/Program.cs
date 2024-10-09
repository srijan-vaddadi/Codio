using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the amount of the bill in pounds: ");
        double billAmount = double.Parse(Console.ReadLine());

        Console.Write("Please enter the number of guests: ");
        int numberOfGuests = int.Parse(Console.ReadLine());

        double tip = billAmount * 0.12;

        double totalAmount = billAmount + tip;

        double perPerson = totalAmount / numberOfGuests;

        Console.WriteLine($"Tip: {tip} GBP");
        Console.WriteLine($"Total: {totalAmount} GBP");
        Console.WriteLine($"Per person: {perPerson} GBP");
    }
}
