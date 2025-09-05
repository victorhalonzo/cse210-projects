using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("Please enter your grade percentage.");
        string grade = Console.ReadLine();
        int number_grade = int.Parse(grade);
        string letter_grade = "";

        if (number_grade >= 90)
        {
            letter_grade = "A";
        }
        else if (number_grade >= 80)
        {
            letter_grade = "B";
        }
        else if (number_grade >= 70)
        {
            letter_grade = "C";
        }
        else if (number_grade >= 60)
        {
            letter_grade = "D";
        }
        else if (number_grade < 60)
        {
            letter_grade = "F";
        }

        int last_digit = number_grade % 10;
        string sign = "";
        if (last_digit >= 7 && letter_grade!="A" && letter_grade !="F" )
        {
            sign = "+";
        }
        else if (number_grade!=100 && last_digit < 3 && letter_grade!="F" )
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {letter_grade}{sign}");
        if (number_grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed.");
        }
        else
        {
            Console.WriteLine("Continue studying.");
        }
    }
}