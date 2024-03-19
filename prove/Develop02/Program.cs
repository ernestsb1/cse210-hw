using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Add prompts to the prompt generator
        promptGenerator.AddPrompt("Who was the most interesting person I interacted with today?");
        promptGenerator.AddPrompt("What was the best part of my day?");
        promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");
        promptGenerator.AddPrompt(" What did you feel on your wedding day, what would you said about it?");
        promptGenerator.AddPrompt("What did you about loving God, give some reason why is like that?");
        promptGenerator.AddPrompt("How much money did you have in you account, tell us little about it?");


        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program, When we prompts User to Write");
            Console.WriteLine("Please Sellect one of the following choice");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Load ");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine("Prompt: " + prompt);

                    Console.Write("Enter your journal entry: ");
                    string entryText = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    Entry entry = new Entry(date, prompt, entryText);
                    journal.AddEntry(entry);

                    Console.WriteLine("Entry added successfully!");
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Journal entries:");
                    journal.Display();
                    break;

                case 3:
                    Console.Write("Enter the file name to save the journal to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Write("Enter the file name to load the journal from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    Console.WriteLine();
                    break;

                case 5:
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }
}