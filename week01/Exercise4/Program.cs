using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        numbers.Add(number);
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        }

        float sum = 0;
        int maximum = 0;
        int smallest_positive = 10000;
        numbers.Sort();
        foreach (int item in numbers)
        {

            sum += item;
            if (item > maximum)
            {
                maximum = item;
            }
            if (smallest_positive > item && item >= 0)
            {
                smallest_positive = item;
            }
        }

        float average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {maximum}");
        Console.WriteLine($"The smallest positive is {smallest_positive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}