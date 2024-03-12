public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the first thing you think about right now",
            "Where do you prefer to have you summer holiday vacation this year?"
        };

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Response: ");
        string response = Console.ReadLine();
        string date = DateTime.Today.ToString("MM/dd/yyyy");

        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine();
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.Date);
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string date = reader.ReadLine();
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();

                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }

            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File does not exist!");
        }
    }
}

