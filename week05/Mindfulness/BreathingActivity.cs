public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

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



        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(getDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Now breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Done.");
    }
}