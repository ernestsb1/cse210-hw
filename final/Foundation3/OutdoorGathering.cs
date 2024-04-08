using System;
class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()
        }\nWeather: {Weather}";
    }
}

