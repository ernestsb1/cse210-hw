class Reception : Event
{
    public string Email { get; set; }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEmail for RSVP: {Email}";
    }
}
