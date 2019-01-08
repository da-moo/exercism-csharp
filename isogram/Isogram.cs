using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var sanitizedWord = word.ToLower().TakeWhile(x => x != ' ' && x != '-');
        return sanitizedWord.Count() == sanitizedWord.Distinct().Count();
    }
}