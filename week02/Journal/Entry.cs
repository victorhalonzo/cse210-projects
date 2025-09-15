public class Entry
{
    public string _prompt;
    public string _input;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Fecha: {_date}");
        Console.WriteLine($"Pregunta: {_prompt}");
        Console.WriteLine($"Respuesta: {_input}");
        Console.WriteLine(new string('-', 20)); // Dibuja una línea para separar entradas
    }
}