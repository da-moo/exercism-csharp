using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    private const int ReverseValue = 16;

    private static readonly Dictionary<int, string> Decoder = new Dictionary<int, string>
    {
        {1, "wink"},
        {2, "double blink"},
        {4, "close your eyes"},
        {8, "jump"}
    };

    public static string[] Commands(int commandValue)
    {
        var decipheredHandShake = Decoder
            .Where(x => (x.Key & commandValue) != 0)
            .OrderBy(x => x.Key)
            .Select(x => x.Value);

        if ((commandValue & ReverseValue) != 0)
        {
            return decipheredHandShake.Reverse().ToArray();
        }

        return decipheredHandShake.ToArray();
    }
}