using System;
class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        BreathePattern();
        DisplayEndingMessage();
    }

    public void BreathePattern()
    {
        Console.WriteLine(" WELCOME TO ERNEST BREATHING SELF-CARE EXERCISE");

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing..");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
    }
}
