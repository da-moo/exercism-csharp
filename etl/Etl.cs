using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newDict = new Dictionary<string, int>();
        foreach (var pair in old)
        {
            foreach (var letter in pair.Value)
            {
                newDict.Add(letter.ToLower(), pair.Key);
            }
        }

        return newDict;
    }
}