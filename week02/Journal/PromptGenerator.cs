public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}