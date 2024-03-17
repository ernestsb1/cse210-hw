using System;
using System.Collections.Generic;
using System.IO;
class Program;
{

        
{
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        promptGenerator.AddPrompt("Who was the most interesting person I interacted with today?");
        promptGenerator.AddPrompt("What was the best part of my day?");
        promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");
        promptGenerator.AddPrompt("What did you about loving God, give some reason why is like that?");
        promptGenerator.AddPrompt("How much money did you have in you account, tell us little about it?");
        promptGenerator.AddPrompt("What did you feel on your wedding day, what would you said about it?");

        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Entry entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);

        journal.Display();

        Console.WriteLine("Enter filename to save the journal:");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);

        Console.WriteLine("Enter filename to load a journal from:");
        string loadFilename = Console.ReadLine();
        journal.LoadFromFile(loadFilename);

        journal.Display();
    }

}