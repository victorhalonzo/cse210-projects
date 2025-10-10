public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public int getDuration()
    {
        return _duration;
    }
    public void setDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity. \n\n" +
        $"{_description}\n\n" +
        "How long, in seconds, would you like for your session?");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {getDuration()} seconds of the {_name} activity");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }
}