ernest
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date},{entry.PromptText},{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];

                    Entry entry = new Entry(date, promptText, entryText);
                    _entries.Add(entry);
                }
            }
        }
    }
}

