
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random random;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        random = new Random();
    }

    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}