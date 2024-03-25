using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Starting " + _name + " activity...");
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Setting duration to " + _duration + " seconds.");
        Pause(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Ending " + _name + " activity...");
        Console.WriteLine("Good job! You have completed the " + _name + " activity.");
        Console.WriteLine("Total duration: " + _duration + " seconds");
        Pause(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void Pause(int seconds)
    {
        ShowCountDown(seconds);
        Console.WriteLine();
    }
}

