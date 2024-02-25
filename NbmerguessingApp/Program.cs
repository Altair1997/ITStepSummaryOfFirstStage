using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minRange = 1;
            int maxRange = 10;
            int secretNumber = random.Next(minRange, maxRange + 1);
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine($"Guess number between {minRange} and {maxRange}.");

            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Input is not a number.");
                    continue;
                }

                attempts++;
                
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try a lower number.");
                }
                else

                {
                    guessedCorrectly = true;
                    Console.WriteLine($"You guessed the number {secretNumber} in {attempts} attempts.");
                }
            }
        }
    }
}