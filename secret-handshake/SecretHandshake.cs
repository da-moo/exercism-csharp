using System.Collections.Generic;

public static class SecretHandshake
{
    private static readonly List<(int Number, string Event)> HandshakeEvents = new List<(int Number, string Event)>
    {
        (1, "wink"),
        (2, "double blink"),
        (4, "close your eyes"),
        (8, "jump")
    };

    public static string[] Commands(int commandValue)
    {
        var retVal = new List<string>();

        foreach (var (number, @event) in HandshakeEvents)
            if ((commandValue & number) != 0)
                retVal.Add(@event);

        if ((commandValue & 16) != 0) retVal.Reverse();

        return retVal.ToArray();
    }
}