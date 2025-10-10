public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description) :
    base(name, description)
    {
        _prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
        ];
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
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write(GetRandomQuestion());
            foreach (string item in animest)
            {
                Console.Write(item);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
         Console.WriteLine("Well done!!");

    }

    public string GetRandomPrompt()
    {
        string prompt = "";

        Random random = new Random();

        int indiceAleatorio = random.Next(_prompts.Count);

        prompt = _prompts[indiceAleatorio];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        string question = "";
        Random random = new Random();
        int indiceAleatorio = random.Next(_questions.Count);
        question = _questions[indiceAleatorio];
        return question;
    }

    public void DisplayPrompt() { }

    public void DisplayQuestions() { }
}