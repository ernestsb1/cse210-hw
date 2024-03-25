using System;
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = new List<string> 

        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Thread.Sleep(5000); // Pause for 5 seconds

        Console.WriteLine("Start listing items:");
        _count = _duration;

        List<string> items = GetListFromUser();
        Console.WriteLine($"You have listed {_count} items.");

    

         DisplayEndingMessage();
    }
     

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
     
     private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        for (int i = 1; i <= _count; i++)
        {
            Console.Write($"Item {i}: ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}


    
    



     


