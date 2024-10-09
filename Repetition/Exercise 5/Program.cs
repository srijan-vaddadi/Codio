using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int correctCount = 0;
        int wrongCount = 0;

        Console.WriteLine("Subtraction Quiz Challenge");

        for (int i = 1; i <= 5; i++)
        {
            int num1 = rand.Next(0, 35);
            int num2 = rand.Next(0, 35);

            Console.WriteLine($"What is {num1} - {num2}? ");
            int userAnswer = int.Parse(Console.ReadLine());

            int correctAnswer = num1 - num2;

            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("You are correct!");
                correctCount++;
            }
            else
            {
                Console.WriteLine($"Your answer is wrong.\n{num1} - {num2} should be {correctAnswer}");
                wrongCount++;
            }
        }

        Console.WriteLine("################## YOUR RESULT ######################");
        Console.WriteLine($"Correct count is {correctCount}");
        Console.WriteLine($"Wrong count is {wrongCount}");
    }
}
