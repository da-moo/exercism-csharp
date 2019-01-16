using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    private static readonly (string Letters, int Score)[] ScoreData =
    {
        ("AEIOULNRST", 1),
        ("DG", 2),
        ("BCMP", 3),
        ("FHVWY", 4),
        ("K", 5),
        ("JX", 8),
        ("QZ", 10)
    };

    private static readonly Dictionary<char, int> ScoreDictionary = new Dictionary<char, int>();

    static ScrabbleScore()
    {
        foreach (var (letters, score) in ScoreData)
        foreach (var letter in letters)
            ScoreDictionary.Add(letter, score);
    }

    public static int Score(string input)
    {
        return input.ToUpper().Select(x => ScoreDictionary[x]).Sum();
    }
}