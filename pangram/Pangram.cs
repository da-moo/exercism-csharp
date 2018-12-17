using System.Text.RegularExpressions;

public static class Pangram
{
    private static readonly Regex AlphaUniqueCountPattern = new Regex(@"([a-z])(?!.*\1)", RegexOptions.Compiled);
    public static bool IsPangram(string input) => AlphaUniqueCountPattern.Matches(input.ToLower()).Count == 26;
}
