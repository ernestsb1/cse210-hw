

using System;
class Program
{
    static void Main(string[] args)
    {
        
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        bool exit = false;

        while (exit)
            Console.WriteLine("You have 0 point");
            Console.WriteLine("Main Menu Option");
            //Console.WriteLine("-");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
           // Console.WriteLine("-");

            Console.WriteLine("Enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    goalManager.DisplayPlayerInfo();
                    break;
                case 2:
                    goalManager.ListGoalNames();
                    break;
                case 3:
                    goalManager.ListGoalDetails();
                    break;
                case 4:
                    goalManager.CreateGoal();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    goalManager.SaveGoals();
                    break;
                case 7:
                    goalManager.LoadGoals();
                    break;
                case 8:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

