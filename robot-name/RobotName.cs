using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Robot
{
    private static readonly HashSet<string> Seen = new HashSet<string>();

    public Robot() => Reset();

    public string Name { get; private set; }

    public void Reset()
    {
        string generatedName;
        do
        {
            generatedName = GenerateName();
        } while (Seen.Contains(generatedName));

        Name = generatedName;
        Seen.Add(generatedName);
    }

    private static string GenerateName()
    {
        var builder = new StringBuilder();
        var random = new Random();
        builder.AppendJoin("", Enumerable.Repeat((char) ('A' + random.Next(0, 27)), 2));
        builder.AppendJoin("", Enumerable.Repeat(random.Next(0, 10), 3));
        return builder.ToString();
    }
}
