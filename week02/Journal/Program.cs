using System;

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal journal = new Journal();

        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write \n" +
             "2. Display \n" +
             "3. Load \n" +
             "4. Save \n" +
             "5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._prompt = prompts.GetRandomPrompt();
                Console.WriteLine(entry._prompt);
                entry._date = DateTime.Now.ToString("d");
                entry._input = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the name of your file?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == "4")
            {
                Console.WriteLine("What is the name of your file?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }

    }
}