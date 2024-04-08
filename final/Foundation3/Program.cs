class Program
{
    static void Main(string[] args)
    {
        // Create instances of each event type
        var lecture = new Lecture
        {
            Title = "Sample Lecture",
            Description = "This is a sample lecture event.",
            Date = new DateTime(2024, 4, 9),
            Time = new TimeSpan(16, 09, 10),
            Address = new Address { Street = "18 Royal Palm St", City = "City Abuja", State = "State FCT", ZipCode = "111910" },
            Speaker = "Ernest Ohwojeheri",
            Capacity = 50
        };

        var reception = new Reception
        {
            Title = "Reception",
            Description = "This is the reception event.",
            Date = new DateTime(2024, 1, 4),
            Time = new TimeSpan(18, 0, 0),
            Address = new Address { Street = "210 Castle Ave", City = "City ", State = "State ", ZipCode = "44567" },
            Email = "sample@email.com"
        };

        var outdoorGathering = new OutdoorGathering
        {
            Title = "Sample Outdoor Gathering",
            Description = "This is the outdoor gathering event.",
            Date = new DateTime(2024, 5, 8),
            Time = new TimeSpan(12, 10, 08),
            Address = new Address { Street = "194 Robot Ave", City = "City Miami", State = "State Florida", ZipCode = "33101" },
            Weather = "Sunny"
        };

        
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
