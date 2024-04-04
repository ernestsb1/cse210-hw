using System.Drawing;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Goal Quest Program!");
        Console.WriteLine();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");            
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu): ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("Player Info:");
        Console.WriteLine("Score: " + _score);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Which type of Goal would you like to create? ");
        Console.Read();
        Console.Write("What is the name of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        Console.ReadLine();
        Console.Write("What is the amount of point associate with it? ");
        Console.ReadLine();



    




        foreach (Goal goal in _goals)
        {
            Console.WriteLine("- " + goal);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine("Name: " + goal);
            Console.WriteLine("Description: " + goal);
            Console.WriteLine("Completed: " + goal);
            Console.WriteLine();
        }
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("Types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of Goal would you like to create? ");
        string name = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        Console.ReadLine();
        Console.WriteLine("What is the amount of point associate with it? ");
        Console.ReadLine();

        
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Record Event:");
        Console.WriteLine("Choose a goal to record the event for:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i]);
        }

        Console.Write("Enter your choice (1-" + _goals.Count + "): ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            
            _score += 100;

            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

public class GoalTracker;

    public void SaveGoals()
    {
        string[] goals = { "name", "description", "int point" };

        
        string filePath = @"C:\Goals\goals.txt";

        try
        {
           
            File.WriteAllLines(filePath, goals);

            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred while saving goals: " + ex.Message);
        }
    }



    public void LoadGoals()
    {
        Console.WriteLine("Loading Goals...");

        Console.WriteLine("Goals loaded successfully!");
    }
}
