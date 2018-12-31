using System;

public class Clock : IEquatable<Clock>
{
    public Clock(int hours, int minutes)
    {
        if (minutes < 0)
        {
            Hours = Mod(hours - (Math.Abs(minutes) + 60) / 60, 24);
        }
        else
        {
            Hours = Mod(hours + (minutes / 60), 24);
        }
        Minutes = Mod(minutes, 60);
    }

    private int Hours { get; }

    private int Minutes { get; }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hours, Minutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(Hours, Minutes - minutesToSubtract);
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    private static int Mod(int x, int y) {
        return (x % y + y) % y;
    }

    public bool Equals(Clock other)
    {
        return Hours == other.Hours && Minutes == other.Minutes;
    }

    public static bool operator ==(Clock left, Clock right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Clock left, Clock right)
    {
        return !Equals(left, right);
    }
}
