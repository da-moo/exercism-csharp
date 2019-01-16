using System.Collections.Generic;

public static class Proverb
{
    private const string VerseTemplate = "For want of a {0} the {1} was lost.";
    private const string FinalVerseTemplate = "And all for the want of a {0}.";

    public static string[] Recite(string[] subjects)
    {
        return subjects.Length == 0 ? new string[]{} : Recite(subjects, new List<string>());
    }

    private static string[] Recite(string[] subjects, List<string> inProgressProverb)
    {
        if (subjects.Length - 1 == inProgressProverb.Count)
        {
            inProgressProverb.Add(string.Format(FinalVerseTemplate, subjects[0]));
            return inProgressProverb.ToArray();
        }

        var currentSubject = subjects[inProgressProverb.Count];
        var nextSubject = subjects[inProgressProverb.Count + 1];
        inProgressProverb.Add(string.Format(VerseTemplate, currentSubject, nextSubject));
        return Recite(subjects, inProgressProverb);
    }
}