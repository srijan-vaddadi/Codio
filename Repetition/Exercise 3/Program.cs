using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        int randomNumber = rand.Next(0, 11);

        int userGuess = -1;
        int attempts = 0;

        Console.WriteLine("Welcome to the guessing game!");
        Console.WriteLine("Try to guess the number between 0 and 10.");

        while (userGuess != randomNumber)
        {
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < randomNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts + 1} attempts.");
            }

            attempts++;
        }
    }
}
