using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = (int)Math.Pow(number, 2);
            return squareNumber;
        }

        static void DisplayResult(string username, int squareNumber)
        {
            Console.WriteLine($"{username}, the square of your number is {squareNumber}");
        }

        DisplayWelcome();
        string username = PromptUserName();
        int favorite_number = PromptUserNumber();
        int squareNumber = SquareNumber(favorite_number);
        DisplayResult(username, squareNumber);        

    }
}