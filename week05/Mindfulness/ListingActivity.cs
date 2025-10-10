public class ListingActivity : Activity
{

    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description)
     : base(name, description)
    {

        _prompts = ["Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"];
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        List<string> animest = new List<string>();
        animest.Add("|");
        animest.Add("/");
        animest.Add("-");
        animest.Add("\\");
        animest.Add("|");
        animest.Add("-");
        animest.Add("/");
        animest.Add("|");
        animest.Add("/");

        foreach (string item in animest)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine("List as many responses you can  to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        List<string> responses = GetListFromUser();
        _count = responses.Count();
        Console.WriteLine($"You have {_count} items");

    }

    public string GetRandomPrompt()
    {
        string prompt = "";

        Random random = new Random();

        int indiceAleatorio = random.Next(_prompts.Count);

        prompt = _prompts[indiceAleatorio];
        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());

        while (DateTime.Now < futureTime)
        {
            list.Add(Console.ReadLine());
        }
        return list;
    }
}