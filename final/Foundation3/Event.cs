class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public Address Address { get; set; }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString("hh\\:mm")}\nAddress: {Address.Street}, {Address.City}, {Address.State} {Address.ZipCode}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Event";
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
