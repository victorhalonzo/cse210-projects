using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine("Menu Options: \n" +
            "   1. Start breathing activity \n" +
            "   2. Start reflecting activity \n" +
            "   3. Start Listing activity \n" +
            "   4. Quit \n" +
            "Select a choice from the menu");

            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity ba = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus in your breathing");
                ba.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                ba.setDuration(duration);
                ba.Run();
                ba.DisplayEndingMessage();
            }

            if (choice == "2")
            {
                ReflectingActivity refact = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");
                refact.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                refact.setDuration(duration);
                refact.Run();
                refact.DisplayEndingMessage();
            }
            if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartingMessage();
                int duration = int.Parse(Console.ReadLine());
                listingActivity.setDuration(duration);
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
        }
    }
}