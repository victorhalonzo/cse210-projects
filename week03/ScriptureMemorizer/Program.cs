using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Load scriptures from an external file
        var scriptures = LoadScriptures("Scripture.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        // Randomly select a scripture
        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        if (!File.Exists(filePath))
            return scriptures;

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                var parts2 = parts[0].Split(' ');
                string book = parts2[0];
                var parts3 = parts2[1].Split(':');
                int chapter = int.Parse(parts3[0]);
                if (!parts3[1].Contains('-'))
                {
                    int verse = int.Parse(parts3[1]);
                    scriptures.Add(new Scripture(new Reference(book, chapter, verse), parts[1]));
                }
                else
                {
                    var parts4 = parts3[1].Split('-');
                    int startVerse = int.Parse(parts4[0]);
                    int endVerse = int.Parse(parts4[1]);
                    scriptures.Add(new Scripture(new Reference(book, chapter, startVerse, endVerse), parts[1]));
                }
            }
        }
        return scriptures;
    }
}