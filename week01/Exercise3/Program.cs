using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /* Console.WriteLine("What is the magic number?");
        string userMagicN = Console.ReadLine();
        int magicNumber = int.Parse(userMagicN); */

        string userResponse = "yes";
        while (userResponse == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            Console.WriteLine(magicNumber);

            Console.WriteLine("What is your guess?");
            string userGuessN = Console.ReadLine();
            int guessNumber = int.Parse(userGuessN);
            int attempts = 1;
            while (guessNumber != magicNumber)
            {
                attempts++;
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higger");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.WriteLine("What is your guess?");
                userGuessN = Console.ReadLine();
                guessNumber = int.Parse(userGuessN);
            }
            Console.WriteLine("You are a lucky man.");
            Console.WriteLine($"You made {attempts} attempts.");

            Console.WriteLine("Do you want to play again?");
            userResponse = Console.ReadLine();
        }
    }
}