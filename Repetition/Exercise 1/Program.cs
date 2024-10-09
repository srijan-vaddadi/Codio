using System;

namespace p4cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any positive or negative integer: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication Table of {num}");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
