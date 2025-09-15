

using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            // Escribir cabecera
            sw.WriteLine("Date|Prompt|Input");

            // Escribir filas
            foreach (var p in _entries)
            {
                sw.WriteLine($"{p._date}|{p._prompt}|{p._input}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        List<string> items = new List<string>(File.ReadAllLines(file));

        for (int i = 1; i < items.Count; i++)
        {
            string[] partes = items[i].Split('|');
            Entry entry = new Entry();

            entry._date = partes[0];
            entry._prompt = partes[1];
            entry._input = partes[2];
            
            _entries.Add(entry);

        }
    }
}