using System;
using System.IO;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        


        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournalToFile();
                    Console.WriteLine();
                    break;
                case 4:
                    journal.LoadJournalFromFile();
                    Console.WriteLine();
                    break;
                case 5:
                    return;
            }
        }
    }
}
