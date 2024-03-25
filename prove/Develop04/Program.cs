using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "Practice deep breathing exercises.", 45);
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "Reflect on a prompt and answer a question.", 60);
        ListingActivity listingActivity = new ListingActivity("Listing", "List as many items as you can.", 30);

 while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Choose an activity: ");
            int choice = Convert.ToInt32(Console.ReadLine());


       
        int selection = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathingActivity.Run();
                break;
            case 2:
                reflectingActivity.Run();
                break;
            case 3:
                listingActivity.Run();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
               continue;
        }

        

        Console.WriteLine("Thank you for using the ERNEST Self-Care Activity!");
    }
}
}