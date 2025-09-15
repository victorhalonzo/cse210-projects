public class Entry
{
    public string _prompt;
    public string _input;
    public string _date;

    public void Display()
    {
        Console.Write($"Date: {_date} - ");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_input}");
        Console.WriteLine(new string('-', 20)); // Dibuja una línea para separar entradas
    }
}