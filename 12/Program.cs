using System;

namespace guessing
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "apple";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            Console.WriteLine("Guess the secret word!");

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;

                } else{
                    outOfGuesses = true;
                    Console.WriteLine("You are out of guesses!");
                }
            }
            Console.WriteLine("you Win!");

        }
    }
}
