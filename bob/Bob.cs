using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class Bob
{
    private static Regex YELLED_QUESTION_REGEX = new Regex(@"[A-Z]{4,}\?\s*$", RegexOptions.Compiled);
    private static Regex YELL_REGEX = new Regex(@"[A-Z]{4,}!*|[A-Z]+!+", RegexOptions.Compiled);
    private static Regex QUESTION_REGEX = new Regex(@"\?\s*$", RegexOptions.Compiled);
    private static Regex EMPTY_STATEMENT_REGEX = new Regex(@"^\s*$", RegexOptions.Compiled);

    private static Dictionary<Regex, string> responseDict = new Dictionary<Regex, string>(){
        {YELLED_QUESTION_REGEX, "Calm down, I know what I'm doing!"},
        {YELL_REGEX, "Whoa, chill out!"},
        {QUESTION_REGEX, "Sure."},
        {EMPTY_STATEMENT_REGEX, "Fine. Be that way!"},
    };

    public static string Response(string statement)
    {
        foreach (KeyValuePair<Regex, string> responsePair in Bob.responseDict)
        {
            if (responsePair.Key.IsMatch(statement))
            {
                return responsePair.Value;
            }
        }
        return "Whatever.";
    }
}
