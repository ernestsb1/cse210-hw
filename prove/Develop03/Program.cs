using System;

public class Program
{
    public static void Main()
    {
        Reference reference = new Reference("John", 3, 16, 17);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life., For God did not send his Son into the world to condemn the world, but to save the world through him";
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Press enter to hide some words or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            input = Console.ReadLine();
        }
    }
}
