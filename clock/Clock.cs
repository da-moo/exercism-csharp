using System;

public class Clock
{
    public Clock(int hours, int minutes)
    {
        Hours = (hours + (minutes / 60)) % 24;
        Minutes = minutes % 60;
    }

    public int Hours { get; }

    public int Minutes { get; }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hours, Minutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";
}
